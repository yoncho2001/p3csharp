using functions;
using System.Globalization;
using System.Text.RegularExpressions;

namespace task19
{
    public class DatesFromTextInCanada
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string output = "";

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            string pattern = @"[0-9]{2,}\.[0-9]{2,}\.[0-9]{4}";

            Match matches = Regex.Match(input, pattern);
            Console.WriteLine("Found dates:");

            var canadianCult = CultureInfo.CreateSpecificCulture("en-CA");

            while (matches.Success)
            {
                if (DateTime.TryParseExact(matches.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    output += parsedDate.ToString("d", canadianCult) + "\n";
                }

                matches = matches.NextMatch();
            }

            Console.WriteLine(output);
        }
    }
}