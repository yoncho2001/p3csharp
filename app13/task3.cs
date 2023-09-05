using System.IO;
using functions;

namespace task3
{
    public class ReadFileContents
    {
        public static void Result()
        {

            string path;
            try
            {
                path = Functions.CanString();
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("Null input is not allowed");
                return;
            }

            try
            {
                if (!File.Exists(path))
                {
                    throw new ArgumentException("The file dont exist or can't find the drectory.");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file don't exist.");
                return;
            }

            /*string createText = Functions.CanString();

            try
            {
                File.WriteAllText(path, createText);
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
            }*/

            string readText;

            try
            {
                readText = File.ReadAllText(path);
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

            Console.WriteLine(readText);
        }
    }
}