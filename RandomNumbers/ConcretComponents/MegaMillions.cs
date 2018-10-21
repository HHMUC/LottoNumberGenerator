using Lotto.Decorator;
using Lotto.Random;

namespace Lotto.ConcreteImplementation
{
    /// <summary>
    /// description: concrete component megamillions  
    /// creator: HHMUC
    /// contact: hhmuc@abwesend.de
    /// last edited: 21.10.2018
    /// </summary>
    public class MegaMillions : Lottotip
    {
        public MegaMillions()
        {
            IsSpecialNumber = true;
            LotteryName = "Mega Millions";
           
            Numbers = new Intervall
            {
                Start = 1,
                Stop = 70
            };
            SpecialNumber = new Intervall
            {
                Start = 1,
                Stop = 25
            };

            NumbersCount = 5;
            SpecialNumbersCount = 1;
        }

        public override void PrintToScreen()
        {
            base.PrintToScreen();
        }
    }
}
