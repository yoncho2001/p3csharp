using functions;
using System.Text;

namespace task7
{
    public class EncodeDecode
    {
        public static void Result()
        {
            StringBuilder arrElements = new StringBuilder();
            const int maxSize = 20;
            string input = Console.ReadLine();
            string keys = Console.ReadLine();

            if (input == null || keys == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            string result = xorEncode(keys, input);
            Console.WriteLine(result);

            Console.WriteLine(xorDecode(keys, result));
        }

        public static string xorEncode(string keys, string input)
        {
            StringBuilder output = new StringBuilder();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (count == keys.Length)
                {
                    count = 0;
                }

                output.Append((char)(input[i] ^ keys[count]));
                count++;
            }

            String result = output.ToString();

            return result;
        }

        public static string xorDecode(string keys, string input)
        {
            StringBuilder output = new StringBuilder();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (count == keys.Length)
                {
                    count = 0;
                }

                output.Append((char)(keys[count] ^ input[i]));
                count++;
            }

            String result = output.ToString();

            return result;
        }
    }
}