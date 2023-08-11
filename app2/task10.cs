namespace task10
{
    public class Interval
    {
        public static void Result()
        {
            int number1;
            int number2;
            int count = 0;

            if (!int.TryParse(Console.ReadLine(), out number1)
                || !int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            
            int max = Math.Max(number1, number2);
            int min = Math.Min(number1, number2);

            for (int i = min+1; i < max; i++)
            {
                if (i % 5 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}