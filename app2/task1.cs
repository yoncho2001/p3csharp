namespace task1
{
    public class SumOfThreeNumbers
    {
        public static void Result()
        {
            double first;
            double second;
            double third;

            if (!double.TryParse(Console.ReadLine(), out first)
                || !double.TryParse(Console.ReadLine(), out second)
                || !double.TryParse(Console.ReadLine(), out third))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine(first + second + third);
        }
    }
}