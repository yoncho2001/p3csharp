using System.IO;
using functions;

namespace task2
{
    public class ConcatenateTextFiles
    {
        public static void Result()
        {
            string path1 = Functions.CanString();
            string path2 = Functions.CanString();
            string path3 = Functions.CanString();

            try
            {
                Functions.fileExist(path1);
                Functions.fileExist(path2);
                Functions.fileExist(path3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string readText = "";
            readText = File.ReadAllText(path1) + "\n";
            readText += File.ReadAllText(path2);

            File.WriteAllText(path3, readText);
        }
    }
}