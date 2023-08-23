using functions;
using System.Text;
using System.Text.RegularExpressions;

namespace task25
{
    public class ExtractTextFromHTML
    {
        public static void Result()
        {
            string input = @"
<html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">
Telerik Academy</a>aims to provide free real-world practical
training for young people who want to turn into
skilful .NET software engineers.</p></body>
</html>";
            StringBuilder output = new StringBuilder();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int indexTitle = input.IndexOf("<title>");

            output.Append("Title: ");
            indexTitle += 7;

            while (input[indexTitle] != '<')
            {
                output.Append(input[indexTitle]);
                indexTitle++;
            }

            output.Append("\nText: ");
            input = input.Remove(0, indexTitle + 8);

            int indexText = input.IndexOf("<");
            int countToReplace = 0;

            while (input.Contains("<"))
            {
                while (input[countToReplace] != '>')
                {
                    countToReplace++;
                }

                input = input.Remove(indexText, countToReplace + 1 - indexText);
                indexText = input.IndexOf("<");
                countToReplace = indexText;
            }

            output.Append(input);
            Console.WriteLine(output);
        }
    }
}