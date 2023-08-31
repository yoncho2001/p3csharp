using System.IO;
using functions;

namespace task3
{
    public class LineNumbers
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

            string[] readText = File.ReadAllLines(path1);

            for (int i = 0; i < readText.Length; i++)
            {
                readText[i] = i.ToString() + ". " + readText[i];
            }

            File.WriteAllLines(path2, readText);
        }
    }
}