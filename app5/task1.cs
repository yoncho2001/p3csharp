using functions;

namespace task1
{
    public class AllocateArray
    {
        public static void Result()
        {
            int number = Functions.CanInt();
            string output = "";
            int[] iPowFive = new int[number];

            for (int i = 0; i < number; i++)
            {
                output += (i * 5).ToString();

                if (i + 1 <= number)
                {
                    output += "\n";
                }
            }

            Console.WriteLine(output);
        }
    }
}