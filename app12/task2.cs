using functions;
using System.Text;

namespace task2
{
    public class ReversString
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            StringBuilder arrElements = new StringBuilder();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                arrElements.Append(input[i]);
            }

            Console.WriteLine(arrElements);
        }
    }
}