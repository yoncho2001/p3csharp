namespace task6
{
    public class FourDigits
    {
        public static void Result()
        {
            string? number = Console.ReadLine();

            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int a = number[0] - '0';
            int b = number[1] - '0';
            int c = number[2] - '0';
            int d = number[3] - '0';
            string output = Convert.ToString(a + b + c + d) + "\n"
                        + number[3] + number[2] + number[1] + number[0] + "\n"
                        + number[3] + number[0] + number[1] + number[2] + "\n"
                        + number[0] + number[2] + number[1] + number[3];
            Console.WriteLine(output);
        }
    }
}