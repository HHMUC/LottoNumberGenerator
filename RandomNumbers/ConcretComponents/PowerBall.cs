using Lotto.Decorator;
using Lotto.Random;

namespace Lotto.ConcreteImplementation
{
    /// <summary>
    /// description: concrete component power ball  
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class PowerBall : Lottotip
    {
        public PowerBall()
        {
            IsSpecialNumber = true;
            LotteryName = "PowerBall";

            Numbers = new Intervall
            {
                Start = 1,
                Stop = 69
            };
            SpecialNumber = new Intervall
            {
                Start = 1,
                Stop = 26
            };

            NumbersCount = 5;
            SpecialNumbersCount = 1;
        }
    }
}
