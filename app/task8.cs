namespace task8
{
    public class PrimeCheck
    {
        public static void Result()
        {
            int x;

            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            bool isPrime = true;

            if (x < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            Console.WriteLine(isPrime);
        }
    }
}