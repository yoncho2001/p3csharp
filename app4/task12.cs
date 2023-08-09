using functions;

namespace task12
{
    public class DecimalToBinary
    {
        public static void Result()
        {
            int numberDEcimal;
            string output = "";

            if (!int.TryParse(Console.ReadLine(), out numberDEcimal))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            while (numberDEcimal > 0)
            {
                output += numberDEcimal % 2 == 1 ? "1" : "0";
                numberDEcimal /= 2;
            }
            Console.WriteLine(Functions.Reverse(output));
        }
    }
}