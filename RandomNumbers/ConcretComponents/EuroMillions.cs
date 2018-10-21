using Lotto.Decorator;
using Lotto.Random;


namespace Lotto.ConcreteImplementation
{
    /// <summary>
    /// description: concrete component euromillions  
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class EuroMillions:Lottotip
    {
        public EuroMillions()
        {
            IsSpecialNumber = true;
            LotteryName = "Euro Millions";

            Numbers = new Intervall
            {
                Start = 1,
                Stop = 50
            };
            SpecialNumber = new Intervall
            {
                Start = 1,
                Stop = 12
            };

            NumbersCount = 5;
            SpecialNumbersCount = 2;
        }        
    }
}
