using functions;
using System.Text;

namespace task13
{
    public class ReverseSentence
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            List<string> words = new List<string>();
            StringBuilder output = new StringBuilder();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == ',' || input[i] == '.' || input[i] == '!' || i == input.Length - 1)
                {
                    words.Add(input.Substring(count, i - count));
                    words.Add(input[i].ToString());
                    count = i + 1;
                }
            }

            string endOfSentence = words[words.Count - 1];

            for (int i = words.Count - 2; i >= 0; i--)
            {
                output.Append(words[i]);
            }

            output.Append(endOfSentence);
            Console.WriteLine(output);
        }
    }
}