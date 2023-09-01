using System.IO;
using System.Text.RegularExpressions;
using functions;

namespace task11
{
    public class PrefixTest

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

            string[] readText = File.ReadAllLines(path);
            string line;
            string output = "";

            for (int i = 0; i < readText.Length; i++)
            {
                string pattern = @"\btest[a-zA-Z]*\b";
                line = Regex.Replace(readText[i], pattern, "");
                output += line + "\n";
            }


            File.WriteAllText(path, output);
        }
    }
}