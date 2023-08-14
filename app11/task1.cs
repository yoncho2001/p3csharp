using functions;

namespace task1
{
    public class FillTheMatrix
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string character = Console.ReadLine();
            int[,] elementsArr = new int[numberN,numberN];
            int count = 1;

            switch (character)
            {
                case "a":
                    for (int i = 0; i < numberN; i++)
                    {
                        for (int j = 0; j < numberN; j++)
                        {
                            if (i % 2 == 0)
                            {
                                elementsArr[j, i] = count;
                                count++;
                            }
                            else
                            {
                                elementsArr[j, i] = count;
                                count++;
                            }
                        }
                    }
                    break;
                case "b":
                    for (int i = 0; i < numberN; i++)
                    {
                        for (int j = 0; j < numberN; j++)
                        {
                            if (i % 2 == 0)
                            {
                                elementsArr[j,i] = count;
                                count++;
                            }
                            else
                            {
                                elementsArr[numberN - j - 1,i] = count;
                                count++;
                            }
                        }
                    }
                    break;
                case "c":
                    // task3.Circle.Result();
                    break;
                case "d":
                    int columnBeginning = 0;
                    int columnEnd = numberN - 1;

                    while (count <= numberN * numberN)
                    {
                        for (int i = columnBeginning; i <= columnEnd; i++)
                        {
                            elementsArr[columnBeginning, i] = count++;
                        }

                        for (int i = columnBeginning + 1; i <= columnEnd; i++)
                        {
                            elementsArr[i, columnEnd] = count++;
                        }

                        for (int i = columnEnd - 1; i >= columnBeginning; i--)
                        {
                            elementsArr[columnEnd, i] = count++;
                        }

                        for (int i = columnEnd - 1; i >= columnBeginning + 1; i--)
                        {
                            elementsArr[i, columnBeginning] = count++;
                        }
                        columnBeginning++;
                        columnEnd--;
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }

            Functions.PrintMatrix(elementsArr);
        }
    }
}