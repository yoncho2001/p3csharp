namespace task8
{
    public class SumOfNNumbers
    {
        public static void Result()
        {
            int countOnN;
            double sum = 0;

            if (!int.TryParse(Console.ReadLine(), out countOnN))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < countOnN; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out double tempNumber))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                sum += tempNumber;
            }

            Console.WriteLine(sum);
        }
    }
}