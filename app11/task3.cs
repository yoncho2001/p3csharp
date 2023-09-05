using functions;

namespace task3
{
    public class SequenceInMatrix
    {
        public static void Result()
        {
            string insert = Console.ReadLine();
            int maxLength = 1;

            if (insert.Length != 3)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            
            string[] rowsAndColumns = insert.Split(" ");
            int numberN = Int32.Parse(rowsAndColumns[0]);
            int numberM = Int32.Parse(rowsAndColumns[1]);
            string[,] elementsMatrix = new string[numberN, numberM];

            for (int i = 0; i < numberN; i++)
            {
                string insertElements = Console.ReadLine();
                string[] rowElements = insertElements.Split(" ");

                for (int j = 0; j < numberM; j++)
                {
                    elementsMatrix[i, j] = rowElements[j];
                }
            }

            //rows

            for (int i = 0; i < numberN; i++)
            {
                int currentLength = 1;

                for (int j = 1; j < numberM; j++)
                {
                    if (elementsMatrix[i, j] == elementsMatrix[i, j - 1])
                    {
                        currentLength++;
                        maxLength = maxLength < currentLength ? currentLength : maxLength;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                }
            }

            //columns

            for (int i = 0; i < numberM; i++)
            {
                int currentLength = 1;

                for (int j = 1; j < numberN; j++)
                {
                    if (elementsMatrix[j, i] == elementsMatrix[j - 1, i])
                    {
                        currentLength++;
                        maxLength = maxLength < currentLength ? currentLength : maxLength;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                }
            }

            //first diadonal

            for (int i = 1; i < numberN; i++)
            {
                int currentLength = 1;

                if (elementsMatrix[i, i] == elementsMatrix[i - 1, i - 1])
                {
                    currentLength++;
                    maxLength = maxLength < currentLength ? currentLength : maxLength;
                }
                else
                {
                    currentLength = 1;
                }
            }

            //second diadonal
            int firstIndex = numberM - 2;

            for (int i = 1; i < numberN; i++)
            {
                int currentLength = 1;
                
                if (elementsMatrix[firstIndex, i] == elementsMatrix[firstIndex + 1, i - 1])
                {
                    currentLength++;
                    maxLength = maxLength < currentLength ? currentLength : maxLength;
                }
                else
                {
                    currentLength = 1;
                }

                firstIndex--;
            }

            Console.WriteLine(maxLength);
        }
    }
}
