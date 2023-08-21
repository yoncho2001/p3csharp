using functions;

namespace task4
{
    public class SubStringinText
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string searchString = Console.ReadLine();

            int count = 0;

            if (input == null || searchString == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int countIndex = 0;
                bool check = true;

                while (i + countIndex < input.Length && countIndex < searchString.Length)
                {
                    if (input[i + countIndex] != searchString[countIndex])
                    {
                        check = false;
                        break;
                    }

                    countIndex++;
                }

                if (check)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}