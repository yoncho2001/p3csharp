namespace task4
{
    public class NumberComparer

    {
        public static void Result()
        {
            double number;
            double number2;
            string output;

            if (!double.TryParse(Console.ReadLine(), out number)
                || !double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (number > number2)
            {
                output = number.ToString();
            }
            else
            {
                output = number2.ToString();
            }

            Console.WriteLine(output);
        }
    }
}