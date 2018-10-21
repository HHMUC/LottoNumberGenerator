using System.Collections.Generic; 
using System.Text; 

namespace Lotto.Random
{
    /// <summary>
    /// description:  Container for the results of the random number generator
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Number of current row
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// list of number(s)
        /// </summary>
        public List<int> Numbers { get; set; }

        /// <summary>
        /// list of special number(s)
        /// </summary>
        public List<int> SpecialNumbers { get; set; }

        /// <summary>
        /// generate a console printable string of the content
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (SpecialNumbers != null)
            {

                sb.AppendLine("........................");
                sb.AppendLine(string.Format("Field: {0}", Row));
                sb.AppendLine("........................");
                for (int i = 0; i < Numbers.Count; i++)
                {
                    sb.AppendLine(string.Format("{0}:   {1}", i + 1, Numbers[i]));
                }

                for (int i = 0; i < SpecialNumbers.Count; i++)
                {
                    if (i == 0 && SpecialNumbers.Count > 1)
                    {
                        sb.Append("Special: " + SpecialNumbers[i] + ",");
                    }
                    else if (i == 0 && SpecialNumbers.Count == 1)
                    {
                        sb.Append("Special: " + SpecialNumbers[i]);
                    }
                    else if (i < SpecialNumbers.Count - 1)
                    {
                        sb.Append(SpecialNumbers[i] + ",");
                    }
                    else
                    {
                        sb.Append(SpecialNumbers[i]);
                    }
                }


            }
            else
            {
                sb.AppendLine("........................");
                sb.AppendLine(string.Format("Row: {0}", Row));
                sb.AppendLine("........................");
                for (int i = 0; i < Numbers.Count; i++)
                {
                    sb.AppendLine(string.Format("{0}:   {1}", i + 1, Numbers[i]));
                }
            }
            return sb.ToString();
        }
    }
}
