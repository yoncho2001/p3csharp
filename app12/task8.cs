using functions;
using System.Text;

namespace task8
{
    public class ExtractSentences
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string searchWord = Console.ReadLine();
            StringBuilder tempWord = new StringBuilder();
            string output = "";

            if (input == null || searchWord == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                while (input[i] != ' ' && input[i] != '.' && input[i] != '\0' && i < input.Length)
                {
                    tempWord.Append(input[i]);
                    i++;
                }

                if (tempWord.ToString() == searchWord)
                {
                    output += getSentence(i, input);
                }

                tempWord = new StringBuilder();
            }

            Console.WriteLine(output);
        }

        public static string getSentence(int index, string input)
        {
            int countIndexSentence = index;

            while (input[countIndexSentence] != '.' && countIndexSentence > 0)
            {
                countIndexSentence--;
            }

            int startS = countIndexSentence;
            countIndexSentence = index;

            while (input[countIndexSentence] != '.' && countIndexSentence < input.Length)
            {
                countIndexSentence++;
            }

            int endS = countIndexSentence;
            return input.Substring(startS, endS - startS);
        }
    }
}