using functions;

namespace task7
{
    public class CalculateThree
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

            sum = Functions.Factorial(numberN) / (Functions.Factorial(numberK) * Functions.Factorial(numberN - numberK)) ;
            Console.WriteLine("{0:0}", sum);
        }
    }
}