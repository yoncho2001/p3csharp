namespace task7
{
    public class SortThreeNumbers

    {
        public static void Result()
        {
            double number1;
            double number2;
            double number3;
            double max;
            double between;
            double min;

            if (!double.TryParse(Console.ReadLine(), out number1)
                || !double.TryParse(Console.ReadLine(), out number2)
                || !double.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (number1 > number2)
            {
                between = number1;
                min = number2;
            }
            else
            {
                between = number2;
                min = number1;
            }
            if (between > number3)
            {
                max = between;
                if (min > number3)
                {
                    between = min;
                    min = number3;
                }
                else
                {
                    between = number3;
                }
            }
            else max = number3;

            Console.WriteLine(max.ToString() + " " + between.ToString() + " " + min.ToString());
        }
    }
}