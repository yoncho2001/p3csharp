using functions;
using System.Globalization;

namespace task17
{
    public class DateInBulgarian
    {
        public static void Result()
        {
            Console.WriteLine("Enter the first date: ");
            string date = Console.ReadLine();
            TimeSpan time = new TimeSpan(6, 30, 0);

            if (date == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (!DateTime.TryParseExact(date, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateInFormat))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            DateTime datePlus = dateInFormat + time;
            var bulgarianCult = CultureInfo.CreateSpecificCulture("bul-bg");
            string output = datePlus.ToString("dd.MM.yyyy HH:mm  ", bulgarianCult);
            output += datePlus.ToString("dddd");

            Console.WriteLine(output);
        }
    }
}