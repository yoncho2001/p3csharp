using functions;
using System.Text;

namespace task10
{
    public class UnicodeCharacters
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                output.AppendFormat("\\u{0:X4}", (int)input[i]);
            }

            Console.WriteLine(output.ToString());
        }
    }
}