using System.IO;
using functions;

namespace task4
{
    public class CompareTextFiles
    {
        public static void Result()
        {
            string path1 = Functions.CanString();
            string path2 = Functions.CanString();
            int equalLines = 0;
            int notEqualLines = 0;

            try
            {
                Functions.fileExist(path1);
                Functions.fileExist(path2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string[] readText1 = File.ReadAllLines(path1);
            string[] readText2 = File.ReadAllLines(path2);

            for (int i = 0; i < readText1.Length; i++)
            {
                if (readText1[i] == readText2[i])
                {
                    equalLines++;
                }
                else
                {
                    notEqualLines++;
                }
            }

            string output = "Equal lines:" + equalLines.ToString() + "\n";
            output += "Not equal lines:" + notEqualLines.ToString();
            Console.WriteLine(output);
        }
    }
}