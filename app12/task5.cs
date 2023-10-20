using functions;
using System.Text;

namespace task5
{
    public class ParseTags
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            StringBuilder arrElements = new StringBuilder();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            const string openTag = "<upcase>";
            const string closeTag = "</upcase>";

            while (input.Contains(openTag) && input.Contains(closeTag))
            {
                int startUpper = input.IndexOf(openTag);
                int endUpper = input.IndexOf(closeTag);

                if (startUpper < endUpper)
                {
                    string toBeReplaced = input.Substring(startUpper, endUpper - startUpper + closeTag.Length);
                    string upperContent = input.Substring(startUpper + openTag.Length, endUpper - startUpper - openTag.Length).ToUpper();
                    input = input.Replace(toBeReplaced, upperContent);
                }
                else
                {
                    input = input.Remove(endUpper, closeTag.Length);
                }
            }

            Console.WriteLine(input);
        }
    }
}