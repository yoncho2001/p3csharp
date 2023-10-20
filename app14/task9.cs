using System.IO;
using functions;

namespace task9
{
    public class DeleteOddLines
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
            }

            string[] readText = File.ReadAllLines(path);
            string output = "";

            for (int i = 0; i < readText.Length; i += 2)
            {
                output += readText[i] + "\n";
            }

            File.WriteAllText(path, output);
        }
    }
}