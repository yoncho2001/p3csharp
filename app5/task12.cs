using functions;

namespace task12
{
    public class IndexOfLetters
    {
        public static void Result()
        {
            string word = Console.ReadLine();
            char[] alphabetArr = Functions.CrateTheAlphabet();
            string output = "";

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabetArr.Length; j++)
                {
                    if (alphabetArr[j] == word[i])
                    {
                        output += j.ToString() + "\n";
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}