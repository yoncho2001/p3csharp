namespace task7
{
    public class NumbersFromOnetoN
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
                output += i + "\n";
            }

            Console.WriteLine(output);
        }
    }
}