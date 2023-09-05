namespace task2
{
    public class NotDivisibleNumbers
    {
        public static void Result()
        {
            int number;
            string output = "";

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    output += i.ToString();

                    if (i + 1 <= number)
                    {
                        output += ", ";
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}