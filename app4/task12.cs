using functions;

namespace task12
{
    public class DecimalToBinary
    {
        public static void Result()
        {
            int numberDecimal;
            string output = "";

            if (!int.TryParse(Console.ReadLine(), out numberDecimal))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            while (numberDecimal > 0)
            {
                output += numberDecimal % 2 == 1 ? "1" : "0";
                numberDecimal /= 2;
            }
            Console.WriteLine(Functions.Reverse(output));
        }
    }
}