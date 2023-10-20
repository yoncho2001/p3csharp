using functions;

namespace task7
{
    public class LargestAreaInMatrix
    {
        private static int[,] matrix;
        private static bool[,] visited;

        public static void Result()
        {
            string insert = Console.ReadLine();
            int maxSize = 0;
            int maxElement = 0;

            if (insert.Length != 3)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            string[] rowsAndColumns = insert.Split(" ");
            int numberN = Int32.Parse(rowsAndColumns[0]);
            int numberM = Int32.Parse(rowsAndColumns[1]);

            matrix = new int[numberN, numberM];
            visited = new bool[numberN, numberM];

            for (int i = 0; i < numberN; i++)
            {
                string[] elements = Console.ReadLine().Split(' ');

                for (int j = 0; j < numberM; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]);
                }
            }

            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberM; j++)
                {
                    if (!visited[i, j])
                    {
                        int sizeOfElement = findNeighbours(i, j, matrix[i, j], numberN, numberM);
                        if (sizeOfElement > maxSize)
                        {
                            maxSize = sizeOfElement;
                            maxElement = matrix[i, j];
                        }
                    }
                }
            }

            Console.WriteLine(maxSize.ToString() + " " + maxElement.ToString());
        }

        private static int findNeighbours(int i, int j, int element, int numberN, int numberM)
        {
            if (i < 0 || i >= numberN || j < 0 || j >= numberM)
            {
                return 0;
            }

            if (visited[i, j] || matrix[i, j] != element)
            {
                return 0;
            }

            visited[i, j] = true;

            int sizeOfElement = 1;

            sizeOfElement += findNeighbours(i + 1, j, element, numberN, numberM);
            sizeOfElement += findNeighbours(i - 1, j, element, numberN, numberM);
            sizeOfElement += findNeighbours(i, j + 1, element, numberN, numberM);
            sizeOfElement += findNeighbours(i, j - 1, element, numberN, numberM);

            sizeOfElement += findNeighbours(i + 1, j + 1, element, numberN, numberM);
            sizeOfElement += findNeighbours(i - 1, j - 1, element, numberN, numberM);
            sizeOfElement += findNeighbours(i + 1, j - 1, element, numberN, numberM);
            sizeOfElement += findNeighbours(i - 1, j + 1, element, numberN, numberM);

            return sizeOfElement;
        }
    }
}