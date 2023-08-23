using functions;
using System.Globalization;

namespace task16
{
    public class DateDifference
    {
        public static void Result()
        {
            Console.WriteLine("Enter the first date: ");
            string date1 = Console.ReadLine();

            Console.WriteLine("Enter the second date: ");
            string date2 = Console.ReadLine();

            if (date1 == null || date2 == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (!DateTime.TryParseExact(date1, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date1InFormat)
                || !DateTime.TryParseExact(date2, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date2InFormat))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int days = Math.Abs((date1InFormat - date2InFormat).Days);

            Console.WriteLine(days);
        }
    }
}