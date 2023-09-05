using functions;

namespace task2
{
    public class CompareArrays
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string output = "";
            int[] firstArray = Functions.InsertIntArray(numberN);
            int[] secondArray = Functions.InsertIntArray(numberN);
            bool isEqual = true;

            for (int i = 0; i < numberN; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                }
            }

            output = isEqual ? "Equal" : "Not equal";

            Console.WriteLine(output);
        }
    }
}