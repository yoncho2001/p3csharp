using System.IO;
using System.Text.RegularExpressions;
using functions;

namespace task10
{
    public class ExtractTextFromXML
    {
        public static void Result()
        {
            string path = Functions.CanString();
            

            try
            {
                Functions.fileExist(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            using StreamReader file = new StreamReader(path);
            string line;
            string output = "";

            while ((line = file.ReadLine()) != null)
            {
                string pattern = @"(?<=>)(.*)(?=<)";
                Match match = Regex.Match(line, @"(?<=>)(.*)(?=<)");
                
                if (match.Success)
                {
                    output += match.Value + "\n";
                }
            }

            Console.WriteLine(output);
        }
    }
}