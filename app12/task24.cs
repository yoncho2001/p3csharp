using functions;

namespace task24
{
    public class OrderWords
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string output = "";

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            string[] elements = input.Split(" ");

            Array.Sort(elements);

            for (int i = 0; i < elements.Length; i++)
            {
                output += elements[i] + "\n";
            }

            Console.WriteLine(output);
        }
    }
}