namespace task8
{
    public class SumOfNNumbers
    {
        public static void Result()
        {
            int number;
            double sum = 0;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < number; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double temp))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                sum += temp;
            }

            Console.WriteLine(sum);
        }
    }
}