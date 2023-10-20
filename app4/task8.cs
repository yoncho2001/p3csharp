using functions;

namespace task8
{
    public class CatalanNumbers
    {
        public static void Result()
        {
            int numberN;
            double sum;

            if (!int.TryParse(Console.ReadLine(), out numberN))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            sum = Functions.Factorial(2 * numberN) / (Functions.Factorial(numberN + 1) * Functions.Factorial(numberN));
            Console.WriteLine("{0:0}", sum);
        }
    }
}