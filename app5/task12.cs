using functions;

namespace task12
{
    public class IndexOfLetters
    {
        public static void Result()
        {
            string word = Console.ReadLine();
            char[] alphabetArray = Functions.CreateTheAlphabet();
            string output = "";

            for (int i = 0; i < word.Length; i++)
            {
                output += Array.IndexOf(alphabetArray, word[i]).ToString() + "\n";
            }

            Console.WriteLine(output);
        }
    }
}