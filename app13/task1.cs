using functions;

namespace task1
{
    public class SquareRoot
    {
        public static void Result()
        {
            try
            {
                double input = Functions.CanDouble();

                if (input < 0)
                {
                    throw new ArgumentOutOfRangeException("The number should be non-negative.");
                }

                Console.WriteLine("{0:0.000}", Math.Sqrt(input));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}