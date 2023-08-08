using functions;

namespace task5
{
    public class Calculate
    {
        public static void Result()
        {
            int numberN;
            double x;
            double sum = 1;

            if (!int.TryParse(Console.ReadLine(), out numberN)
                || !double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 1; i <= numberN; i++)
            {
                sum += Functions.Factorial(i) / Math.Pow(x, i);
            }

            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}