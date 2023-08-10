using functions;

namespace task2
{
    public class CompareArrays
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string output = "";
            int[] firstArr = Functions.InsertIntArr(numberN);
            int[] secondArr = Functions.InsertIntArr(numberN);
            bool isEqual = true;

            for (int i = 0; i < numberN; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isEqual = false;
                }
            }

            output = isEqual ? "Equal" : "Not equal";

            Console.WriteLine(output);
        }
    }
}