namespace task4
{
    public class MultiplicationSign

    {
        public static void Result()
        {
            double number1;
            double number2;
            double number3;
            string outcome;

            if (!double.TryParse(Console.ReadLine(), out number1)
                || !double.TryParse(Console.ReadLine(), out number2)
                || !double.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (number1 * number2 * number3 < 0)
            {
                outcome = "-";
            }
            else if (number1 * number2 * number3 > 0)
            {
                outcome = "+";
            }
            else
            {
                outcome = "0";
            }

            Console.WriteLine(outcome);
        }
    }
}