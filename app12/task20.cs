using functions;

namespace task20
{
    public class Palindromes
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            List<string> words = new List<string>();
            string output = "";

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]) || i == input.Length - 1)
                {

                    if (i == input.Length - 1 && char.IsLetterOrDigit(input[i]))
                    {
                        words.Add(input.Substring(count, i - count + 1));
                    }
                    else
                    {
                        words.Add(input.Substring(count, i - count));
                    }

                    count = i + 1;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                string reverse = Functions.ReverceStr(words[i]);

                if (reverse.ToString() == words[i])
                {
                    output += words[i] + " ";
                }
            }

            Console.WriteLine(output);
        }
    }
}