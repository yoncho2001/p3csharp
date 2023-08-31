using System.IO;
using functions;

namespace task6
{
    public class SaveSortedNames
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
            Array.Sort(readText);

            File.WriteAllLines(path2, readText);
        }
    }
}