using functions;
using System.Text;

namespace task6
{
    public class StringLength
    {
        public static void Result()
        {
            StringBuilder arrElements = new StringBuilder();
            const int maxSize = 20;
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < maxSize; i++)
            {

                if (i < input.Length)
                {
                    arrElements.Append(input[i]);
                }
                else
                {
                    arrElements.Append('*');
                }
            }

            Console.WriteLine(arrElements);
        }
    }
}