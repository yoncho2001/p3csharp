namespace task6
{
    public class CalculateAgain
    {
        public static void Result()
        {
            int numberN;
            int numberK;
            double sum ;

            if (!int.TryParse(Console.ReadLine(), out numberN)
                || !int.TryParse(Console.ReadLine(), out numberK))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            sum = Factorial(numberN) / Factorial(numberK) ;
            Console.WriteLine("{0:0.00}", sum);
        }

        public static double Factorial(double number)
        {
            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}