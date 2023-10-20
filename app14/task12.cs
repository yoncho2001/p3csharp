using System.IO;
using System.Text.RegularExpressions;
using functions;

namespace task12
{
    public class RemoveWords

    {
        public static void Result()
        {
            string pathWords = Functions.CanString();
            string pathText = Functions.CanString();

            try
            {
                Functions.fileExist(pathWords);
                Functions.fileExist(pathText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] words = File.ReadAllLines(pathWords);
            string[] readText = File.ReadAllLines(pathText);
            
            string line = "";
            string output = "";

            for (int i = 0; i < readText.Length; i++)
            {
                line = readText[i];
                for (int j = 0; j < words.Length; j++)
                {
                    string pattern = @"\b" + words[j] + @"\b";
                    line = Regex.Replace(line, pattern, "");
                }
                output += line + "\n";
            }


            File.WriteAllText(pathText, output);
        }
    }
}