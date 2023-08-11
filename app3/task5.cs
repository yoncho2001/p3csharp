namespace task5
{
    public class BiggestOfFive

    {
        public static void Result()
        {
            double number1;
            double number2;
            double number3;
            double number4;
            double number5;

            if (!double.TryParse(Console.ReadLine(), out number1)
                || !double.TryParse(Console.ReadLine(), out number2)
                || !double.TryParse(Console.ReadLine(), out number3)
                || !double.TryParse(Console.ReadLine(), out number4)
                || !double.TryParse(Console.ReadLine(), out number5))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            double max = number1;
            max = Max(max, number2);
            max = Max(max, number3);
            max = Max(max, number4);
            max = Max(max, number5);

            Console.WriteLine(max);
        }

        public static double Max(double x, double y)
        {
            if (x < y)
            {
                x = y;
            }
            return x;
        }
    }
}