namespace task6
{
    public class SumOfFiveNumbers
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

            Console.WriteLine(number1 + number2 + number3 + number4 + number5);
        }
    }
}