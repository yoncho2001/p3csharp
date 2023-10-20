using System.IO;
using functions;

namespace task1
{
    public class OddLines
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

            string[] readText;

            try
            {
                readText = File.ReadAllLines(path);
            }
            catch (IOException throwE)
            {
                Console.WriteLine(throwE.Message);
                return;
            }
            catch (UnauthorizedAccessException throwE)
            {
                Console.WriteLine(throwE.Message);
                return;
            }

            string output = "";

            for (int i = 0; i < readText.Length; i += 2)
            {
                output += readText[i] + "\n";
            }

            Console.WriteLine(output);
        }
    }
}