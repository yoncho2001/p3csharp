using functions;

namespace task16
{
    public class Trailing0InN
    {
        public static void Result()
        {
            int numberN;
            int outputZeroes = 0;

            if (!int.TryParse(Console.ReadLine(), out numberN))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            long factorialN = Functions.FactorialLong(numberN);
            while (factorialN % 10 == 0)
            {
                outputZeroes++;
                factorialN /= 10;
            }

            Console.WriteLine(outputZeroes);
        }
    }
}