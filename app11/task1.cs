using functions;

namespace task1
{
    public class FillTheMatrix
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string character = Console.ReadLine();
            int[,] elementsArr = new int[numberN, numberN];
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
                                elementsArr[j, i] = count;
                                count++;
                            }
                            else
                            {
                                elementsArr[numberN - j - 1, i] = count;
                                count++;
                            }
                        }
                    }
                    break;
                case "c":
                    for (int i = numberN - 1; i >= 0; i--)
                    {
                        int indexCount = 0;

                        for (int j = 0; j < numberN - i; j++)
                        {
                            elementsArr[i + indexCount, j] = count;
                            count++;
                            indexCount++;
                        }
                    }
                    for (int i = 0; i < numberN - 1; i++)
                    {
                        int indexCount = 0;

                        for (int j = 1 + i; j <= numberN - 1; j++)
                        {
                            elementsArr[indexCount, j] = count;
                            count++;
                            indexCount++;
                        }
                    }
                    break;
                case "d":
                    int beginning = 0;
                    int end = numberN - 1;

                    while (count <= numberN * numberN)
                    {
                        for (int i = beginning; i <= end; i++)
                        {
                            elementsArr[i, beginning] = count++;
                        }

                        for (int i = beginning + 1; i <= end; i++)
                        {
                            elementsArr[end, i] = count++;
                        }

                        for (int i = end - 1; i >= beginning; i--)
                        {
                            elementsArr[i, end] = count++;
                        }

                        for (int i = end - 1; i >= beginning + 1; i--)
                        {
                            elementsArr[beginning, i] = count++;
                        }
                        
                        beginning++;
                        end--;
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