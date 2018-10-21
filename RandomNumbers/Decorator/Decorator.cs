using Lotto.Random;
using Newtonsoft.Json;
using System;
using System.Collections.Generic; 

namespace Lotto.Decorator
{
    /// <summary>
    /// description: abstract base class lottery  
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public abstract class Lottery
    {
        private string _lotteryName;  
        public string LotteryName
        {
            get { return _lotteryName; }
            set { _lotteryName = value; }
        }
        private int _numbersCount;
        public int NumbersCount
        {
            get => _numbersCount;
            set => _numbersCount = value;
        }

        private Intervall _numbers;
        public Intervall Numbers
        {
            get { return _numbers; }
            set { _numbers = value; }
        }
        private int _specialNumbersCount;     
        public int SpecialNumbersCount
        {
            get => _specialNumbersCount;
            set => _specialNumbersCount = value;
        }

        private Intervall _specialNumbers;
        public Intervall SpecialNumber
        {
            get { return _specialNumbers; }
            set { _specialNumbers = value; }
        }
        private bool _isSpecialNumber;
        public bool IsSpecialNumber
        {
            get { return _isSpecialNumber; }
            set { _isSpecialNumber = value; }
        }

        

        public abstract List<Result> GenerateTipp();

        public abstract List<Result> GenerateTipps(int number);

        public abstract void PrintToScreen();

        public abstract string GetJson();
    }

    /// <summary>
    /// description: base class for lotto tip generation
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class Lottotip : Lottery
    {
        public Lottotip()
        {            
            
        }
        
        private List<Result> LstTmp { get; set; }

        public override List<Result> GenerateTipp()
        {
            RandomNumberGenerator raNuGe = new RandomNumberGenerator();
            Input input = new Input
            {
                IsSpecialNumber = this.IsSpecialNumber,
                RowNumbers = 1,

                Normal = new Number
                {
                    NumberOfValues = this.NumbersCount,
                    Intervall = this.Numbers
                },

                Special = new Number
                {
                    NumberOfValues = this.SpecialNumbersCount,
                    Intervall =this.SpecialNumber
                }
            };
            this.LstTmp = raNuGe.GenerateNumbers(input);
            return LstTmp;
        }
        public override List<Result> GenerateTipps(int number)
        {
            RandomNumberGenerator raNuGe = new RandomNumberGenerator();
            Input input = new Input
            {
                IsSpecialNumber = this.IsSpecialNumber,
                RowNumbers = number,

                Normal = new Number
                {
                    NumberOfValues = this.NumbersCount,
                    Intervall = this.Numbers
                },

                Special = new Number
                {
                    NumberOfValues = this.SpecialNumbersCount,
                    Intervall = this.SpecialNumber
                }
            };
            this.LstTmp = raNuGe.GenerateNumbers(input);
            return LstTmp;
        }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(LstTmp);             
        }

        public override void PrintToScreen()
        {
            Console.WriteLine();
            Console.WriteLine("***" + this.LotteryName + "***");
            foreach (var item in LstTmp)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
