using System;
using System.Collections.Generic; 
using Newtonsoft.Json;

namespace Lotto.Random
{
    /// <summary>
    /// description: generates random based numbers
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class RandomNumberGenerator
    {
        /// <summary>
        /// ctor based on input object
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Result> GenerateNumbers(Input input)
        {
            List<Result> lstResult = new List<Result>();
            if (input.RowNumbers >= 1 && input.RowNumbers >= 1)
            {
                GenerateNormalNumbers(input.Normal, input.RowNumbers, lstResult);

                if (input.IsSpecialNumber)
                {
                    GenerateSpecialNumbers(input.Special, input.RowNumbers, lstResult);
                }

            }
            return lstResult;
        }

        /// <summary>
        /// ctor based on json serialized input obj
        /// </summary>
        /// <param name="jsonInput"></param>
        /// <returns></returns>
        public List<Result> GenerateNumbers(string jsonInput)
        {
            Input input = JsonConvert.DeserializeObject<Input>(jsonInput);
            List<Result> lstResult = new List<Result>();
            if (input.RowNumbers >= 1 && input.RowNumbers >= 1)
            {
                GenerateNormalNumbers(input.Normal, input.RowNumbers, lstResult);

                if (input.IsSpecialNumber)
                {
                    GenerateSpecialNumbers(input.Special, input.RowNumbers, lstResult);
                }

            }
            return lstResult;
        }

        /// <summary>
        /// Generates normal number lines
        /// </summary>
        /// <param name="normal"></param>
        /// <param name="rowNumbers"></param>
        /// <param name="lstResult"></param>
        private void GenerateNormalNumbers(Number normal, int rowNumbers, List<Result> lstResult)
        {
            for (int j = 1; j <= rowNumbers; j++)
            {
                System.Random ranSeed = new System.Random(GenerateSeed(j));
                Result res = new Result
                {
                    Row = j,
                    Numbers = new List<int>(),
                    SpecialNumbers = new List<int>()

                };
                for (int i = 0; i < normal.NumberOfValues; i++)
                {

                    System.Random ranGeneration = new System.Random(ranSeed.Next(int.MinValue + 1, int.MaxValue - 1));
                    int number = ranGeneration.Next(normal.Intervall.Start, normal.Intervall.Stop);
                    while (res.Numbers.Contains(number))
                    {
                        number = ranGeneration.Next(normal.Intervall.Start, normal.Intervall.Stop);
                    }
                    res.Numbers.Add(number);

                }
                lstResult.Add(res);
            }
        }

        /// <summary>
        /// generates special number(s)
        /// </summary>
        /// <param name="special"></param>
        /// <param name="rowNumbers"></param>
        /// <param name="lstResult"></param>
        private void GenerateSpecialNumbers(Number special, int rowNumbers, List<Result> lstResult)
        {
            for (int j = 1; j <= rowNumbers; j++)
            {
                System.Random ranSeed = new System.Random(GenerateSeed(j));

                for (int i = 0; i < special.NumberOfValues; i++)
                {

                    System.Random ranGeneration = new System.Random(ranSeed.Next(int.MinValue + 1, int.MaxValue - 1));
                    int number = ranGeneration.Next(special.Intervall.Start, special.Intervall.Stop);
                    while (lstResult[j-1].SpecialNumbers.Contains(number))
                    {
                        number = ranGeneration.Next(special.Intervall.Start, special.Intervall.Stop);
                    }
                    lstResult[j-1].SpecialNumbers.Add(number);
                }
            }
        }

        /// <summary>
        /// generates a new seed based on datetime.now
        /// </summary>
        /// <param name="salt"></param>
        /// <returns></returns>
        private int GenerateSeed(int salt)
        {
            int seed = 0;
            seed += salt;
            DateTime d = DateTime.Now;
            seed += d.Day;
            seed += d.DayOfYear;
            seed += d.Hour;
            seed += d.Millisecond;
            seed += d.Minute;
            seed += d.Month;
            seed += d.Second;
            seed += d.Year;

            return seed;
        } 
    } 
}
