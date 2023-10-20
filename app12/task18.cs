using functions;
using System.Text.RegularExpressions;

namespace task18
{
    public class ExtractEmails
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

            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            Match matches = Regex.Match(input, pattern);
            Console.WriteLine("Found emails:");

            while (matches.Success)
            {
                output += matches.Value + "\n";
                matches = matches.NextMatch();
            }

            Console.WriteLine(output);
        }
    }
}