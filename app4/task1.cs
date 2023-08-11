namespace task1
{
    public class NumbersFromOneToN
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
               output += i.ToString() + (i < number ? ", " : "");
            }

            Console.WriteLine(output);
        }
    }
}