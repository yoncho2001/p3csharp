using functions;
using System.Text;

namespace task22
{
    public class WordsCount
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> letters = new Dictionary<string, int>();
            string output = "";
            int count = 0;

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]) || i == input.Length - 1)
                {
                    string wordTolower = "";

                    if (i == input.Length - 1 && char.IsLetterOrDigit(input[i]))
                    {
                        wordTolower = input.Substring(count, i - count + 1).ToLower();
                    }
                    else
                    {
                        wordTolower = input.Substring(count, i - count).ToLower();
                    }

                    if (!letters.ContainsKey(wordTolower))
                    {
                        letters[wordTolower] = 1;
                    }
                    else
                    {
                        letters[wordTolower]++;
                    }

                    count = i + 1;
                }
            }

            foreach (var element in letters)
            {
                output += element.Key.ToString() + " " + element.Value.ToString() + "\n";
            }

            Console.WriteLine(output);
        }
    }
}