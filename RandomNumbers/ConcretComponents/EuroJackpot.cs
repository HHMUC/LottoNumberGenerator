using Lotto.Decorator;
using Lotto.Random;


namespace Lotto.ConcreteImplementation
{
    /// <summary>
    /// description: concrete component eurojackpot  
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class EuroJackpot:Lottotip
    {
        public EuroJackpot()
        {
            IsSpecialNumber = true;
            LotteryName = "Euro Jackpot";

            Numbers = new Intervall
            {
                Start = 1,
                Stop = 50
            };
            SpecialNumber = new Intervall
            {
                Start = 1,
                Stop = 10
            };

            NumbersCount = 5;
            SpecialNumbersCount = 2;
        } 
    }
}
