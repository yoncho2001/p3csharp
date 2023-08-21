using functions;
using System.Text;

namespace task11
{
    public class FormatNumber
    {
        public static void Result()
        {
            double number = Functions.CanDouble();

            Console.WriteLine($"{number,15:F2} (decimal)");
            Console.WriteLine($"{(int)number,15:X} (hexadecimal)");
            Console.WriteLine($"{number,15:P1} (percentage)");
            Console.WriteLine($"{number,15:E2} (scientific)");
        }
    }
}