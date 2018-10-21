using Newtonsoft.Json; 

namespace Lotto.Random
{
    /// <summary>
    /// description: Input data container for generation of the numbers. 
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Normal value row input
        /// </summary>
        public Number Normal { get; set; }
        /// <summary>
        /// Special value row input. Will only be generated if
        /// IsSpecialNumber is set to true
        /// </summary>
        public Number Special { get; set; }
        /// <summary>
        /// indicates the generation of special row
        /// </summary>
        public bool IsSpecialNumber { get; set; }
        /// <summary>
        /// Number of rows that will be generated
        /// </summary>
        public int RowNumbers { get; set; }

        /// <summary>
        /// converts input class to json string
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
