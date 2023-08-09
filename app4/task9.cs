namespace task9
{
    public class MatrixOfNumbers
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

            /*for (int i = 0; i < numberN; i++)
            {
                for (int j = 1; j <= numberN; j++)
                {
                    output += (j+i).ToString() + " ";
                }
                output += "\n";
            }*/
            int br = 0;
            for (int i = 1; i <= numberN; i++)
            {
                output += (i + br).ToString() + " ";

                if (i == numberN)
                {
                    i -= numberN;
                    output += "\n";
                    br++;
                }

                if (br == numberN)
                {
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}