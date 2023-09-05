using functions;

namespace task2
{
    public class MaximalSum
    {
        public static void Result()
        {
            string insert = Console.ReadLine();
            int maxSum = 0;

            if (insert.Length != 3)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            string[] rowsAndColumns = insert.Split(" ");
            int numberN = Int32.Parse(rowsAndColumns[0]);
            int numberM = Int32.Parse(rowsAndColumns[1]);
            int[,] elementsMatrix = new int[numberN, numberM];

            for (int i = 0; i < numberN; i++)
            {
                string insertElements = Console.ReadLine();
                string[] rowElements = insertElements.Split(" ");

                for (int j = 0; j < numberM; j++)
                {
                    elementsMatrix[i, j] = Int32.Parse(rowElements[j]);
                }
            }

            for (int i = 1; i < numberN - 1; i++)
            {
                for (int j = 1; j < numberM - 1; j++)
                {
                    int sum = elementsMatrix[i + 1, j - 1] + elementsMatrix[i + 1, j] + elementsMatrix[i + 1, j + 1]
                            + elementsMatrix[i, j - 1] + elementsMatrix[i, j] + elementsMatrix[i, j + 1]
                            + elementsMatrix[i - 1, j - 1] + elementsMatrix[i - 1, j] + elementsMatrix[i - 1, j + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}