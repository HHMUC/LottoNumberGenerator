namespace Lotto.Random
{
    
    /// <summary>
    /// description: holds the integer intervall and the number of values that should be
    ///              created.
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class Number
    {
        /// <summary>
        /// intervall where the number is included
        /// </summary>
        public Intervall Intervall { get; set; }
        /// <summary>
        /// number of values that will be generated
        /// </summary>
        public int NumberOfValues { get; set; }
    }
}
