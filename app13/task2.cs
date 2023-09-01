using functions;

namespace task2
{
    public class EnterNumbers
    {
        public static void Result()
        {
            const int start = 1;
            const int end = 100;
            string output = "1";

            int temp = start;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    temp = insertInRange(temp, end);
                    output += "<" + temp.ToString();
                }
                
                output += "<" + end.ToString();
                Console.WriteLine(output);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                return;
            }
        }

        public static int insertInRange(int start, int end)
        {
            int input = Functions.CanInt();
            if (input <= start || input >= end)
            {
                throw new ArgumentOutOfRangeException("The number is out of range ");
            }

            return input;
        }
    }
}