using functions;

namespace task21
{
    public class LettersCount
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string output = "";

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    char letterTolower = char.ToLower(input[i]);

                    if (!letters.ContainsKey(letterTolower))
                    {
                        letters[letterTolower] = 1;
                    }
                    else
                    {
                        letters[letterTolower]++;
                    }
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