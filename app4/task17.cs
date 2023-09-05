namespace task17
{
    public class SpiralMatrix
    {
        public static void Result()
        {
            int numberN;
            string output = "";

            if (!int.TryParse(Console.ReadLine(), out numberN))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[,] outputArr = new int[numberN, numberN];
            int arrCount = 1;
            int columnBegining = 0;
            int columnEnd = numberN - 1;

            while (arrCount <= numberN * numberN)
            {
                for (int i = columnBegining; i <= columnEnd; i++)
                {
                    outputArr[columnBegining, i] = arrCount++;
                }

                for (int i = columnBegining + 1; i <= columnEnd; i++)
                {
                    outputArr[i, columnEnd] = arrCount++;
                }

                for (int i = columnEnd - 1; i >= columnBegining; i--)
                {
                    outputArr[columnEnd, i] = arrCount++;
                }

                for (int i = columnEnd - 1; i >= columnBegining + 1; i--)
                {
                    outputArr[i, columnBegining] = arrCount++;
                }
                columnBegining++;
                columnEnd--;
            }

            for (int i = 0; i < numberN; i++)
            {
                for (int j = 0; j < numberN; j++)
                {
                    output += outputArr[i, j] < 10 ? outputArr[i, j].ToString() + "  " : outputArr[i, j].ToString() + " ";
                }

                output += "\n";
            }

            Console.WriteLine(output);
        }
    }
}