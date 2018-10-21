
using Lotto.ConcreteImplementation;

/// <summary>
/// description: console program for simple testing purposes  
/// creator: HHMUC
/// contact: hhmuc@abwesend.de
/// last edited: 21.10.2018
/// </summary>
namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMillions mega = new MegaMillions();
            mega.GenerateTipps(5);
            mega.PrintToScreen();
            string jsonMegaMillions = mega.GetJson();
             
            EuroJackpot euroJackpot = new EuroJackpot();
            euroJackpot.GenerateTipps(6);
            euroJackpot.PrintToScreen();
            string jsonEuroJackpot = euroJackpot.GetJson();

            EuroMillions euroMillions = new EuroMillions();
            euroMillions.GenerateTipps(3);
            euroMillions.PrintToScreen();
            string jsonEuroMillions = euroMillions.GetJson();

            PowerBall powerBall = new PowerBall();
            powerBall.GenerateTipps(3);
            powerBall.PrintToScreen();
            string jsonPowerBall = powerBall.GetJson();

        }        
    }
}
