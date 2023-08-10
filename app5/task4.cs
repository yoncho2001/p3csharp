using functions;

namespace task4
{
    public class MaximalSequence
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int equalLength = 1;
            int maxEqualLength = 0;
            int savedInt;

            int[] elementsArr = Functions.InsertIntArr(numberN);
            savedInt = elementsArr[0];

            for (int i = 1; i < elementsArr.Length; i++)
            {
                if (savedInt == elementsArr[i])
                {
                    equalLength++;
                }
                else
                {
                    savedInt = elementsArr[i];
                    maxEqualLength = maxEqualLength < equalLength ? equalLength : maxEqualLength;
                    equalLength = 1;
                }

            }

            Console.WriteLine(maxEqualLength);
        }
    }
}