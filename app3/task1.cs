namespace task1
{
    public class ExchangeNumbers
    {
        public static void Result()
        {
            double number1;
            double number2;

            if (!double.TryParse(Console.ReadLine(), out number1)
                || !double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (number1 > number2)
            {
                double temp = number1;
                number1 = number2;
                number2 = temp;
            }

            Console.WriteLine(number1 + " " + number2);
        }
    }
}