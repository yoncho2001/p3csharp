namespace task1
{
    public class OddOrEven
    {
        public static void Result()
        {
            Console.WriteLine("Your number = ");
            string output = "No Output";
            int number;

            if(!int.TryParse(Console.ReadLine(), out number)){
                Console.WriteLine("Incorrect input");
                return ;
            }

            if (number % 2 == 0)
            {
                output = "even";
            }
            else
            {
                output = "odd";
            }

            Console.WriteLine(output + " " + number);
        }
    }
}