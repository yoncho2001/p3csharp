using System;
using System.Globalization;
using Phone;

namespace MainNS
{
    static class Program
    {
        static void Main()
        {
            try
            {
                Battery battery = new Battery();
                battery.Model = "67Xg";
                battery.HoursIdle = 20;
                battery.HoursTalk = 15;
                battery.BatteryType = BatteryType.LiIon;

                Display display = new Display();
                display.NumberColor = 100;
                display.Size = 14;

                GSM gsm = new GSM("grigs", "bay pesho", "Ivaka", 205, battery, display);
                //Console.WriteLine(gsm.ToString());
                //GSM gsmDefault = GSM.iPhone4S;
                //Console.WriteLine(GSM.iPhone4S);

                Console.WriteLine(gsm.CallHistory);
                DateTime.TryParseExact("04.06.2023:13:20", "dd.MM.yyyy:HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newDate);

                gsm.addCalls(new Call("04.05.2023:12:56", "0845142000", 120));
                gsm.addCalls(new Call());
                gsm.addCalls(new Call(newDate, "0845145656", 150));
                gsm.addCalls(new Call("10.06.2023:12:56", "0845142522", 120));

                Console.WriteLine(gsm.CallHistory);
                Console.WriteLine(gsm.CallPrice(1));
                gsm.deleteLastCall();
                Console.WriteLine(gsm.CallHistory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        
        }
    }
}