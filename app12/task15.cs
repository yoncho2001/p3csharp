using functions;

namespace task15
{
    public class ReplaceTags
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

            input = input.Replace("<a href=\"", "[URL=");
            input = input.Replace("\">", "]");

            input = input.Replace("</a>", "[/URL]");
            Console.WriteLine(input);
        }
    }
}