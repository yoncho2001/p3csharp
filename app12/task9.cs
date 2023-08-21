using functions;
using System.Text;

namespace task9
{
    public class ForbiddenWords
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split(' ');
            StringBuilder tempWord = new StringBuilder();
            string output = "";

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }            

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                string censorship = "";

                for (int j = 0; j < forbiddenWords[i].Length; j++)
                {
                    censorship += "*";
                }
                input = input.Replace(forbiddenWords[i], censorship);
            }

            Console.WriteLine(input);
        }
    }
}