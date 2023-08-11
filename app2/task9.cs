namespace task9
{
    public class FibonacciNumbers
    {
        public static void Result()
        {
            int number;
            int first = 0;
            int second = 1;
            string output = "";

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            output = "0, 1, ";

            for (int i = 2; i < number; i++)
            {
                output += (first + second).ToString();
                second = first + second;
                first = second - first;

                if (i + 1 < number)
                {
                    output += ", ";
                }
            }

            Console.WriteLine(output);
        }
    }
}