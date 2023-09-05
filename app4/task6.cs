using functions;

namespace task6
{
    public class CalculateAgain
    {
        public static void Result()
        {
            int numberN;
            int numberK;
            double sum;

            if (!int.TryParse(Console.ReadLine(), out numberN)
                || !int.TryParse(Console.ReadLine(), out numberK))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            sum = Functions.Factorial(numberN) / Functions.Factorial(numberK);
            Console.WriteLine("{0:0.00}", sum);
        }
    }
}