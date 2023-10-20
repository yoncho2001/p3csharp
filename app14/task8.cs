using System.IO;
using System.Text.RegularExpressions;
using functions;

namespace task8
{
    public class ReplaceWholeWord
    {
        public static void Result()
        {
            string path1 = Functions.CanString();
            string path2 = Functions.CanString();

            try
            {
                Functions.fileExist(path1);
                Functions.fileExist(path2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            using StreamReader file = new StreamReader(path1);
            using StreamWriter file2 = new StreamWriter(path2);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string pattern = @"\bstart\b";
                line = Regex.Replace(line, pattern, "finish");
                file2.WriteLine(line);
            }

            file.Close();
            file2.Close();
        }
    }
}