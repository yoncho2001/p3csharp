using functions;
using System.Text;

namespace task23
{
    public class SeriesOfLetters
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    output.Append(input[i - 1]);
                }
                if (i == input.Length - 1)
                {
                    output.Append(input[i]);
                }
            }

            Console.WriteLine(output);
        }
    }
}