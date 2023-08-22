using functions;
using System.Text;

namespace task14
{
    public class WordDictionary
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string output = "";
            string[,] dictionary = {{".NET", "platform for applications from Microsoft"},
                                    {"CLR", "managed execution environment for .NET"},
                                    {"namespace", "hierarchical organization of classes"},
                                    {"array", "structure representing a fixed length ordered collection of values"} };

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            bool check = false;

            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                if (dictionary[i, 0] == input)
                {
                    output += dictionary[i, 1];
                    check = true;
                }
            }

            if (!check)
            {
                output += "Dont have this termin";
            }

            Console.WriteLine(output);
        }
    }
}