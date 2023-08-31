using System.IO;
using functions;

namespace task5
{
    public class MaximalAreaSum
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
            int size = int.Parse(readText[0]);
            int[,] matrix = new int[size, size];
            int max = 0;
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] line = readText[i + 1].Split(" ");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    max = max < sum ? sum : max;
                }
            }

            Console.WriteLine(max);
        }
    }
}