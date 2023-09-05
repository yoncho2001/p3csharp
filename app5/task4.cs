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

            int[] elementsArray = Functions.InsertIntArray(numberN);
            savedInt = elementsArray[0];

            for (int i = 1; i < elementsArray.Length; i++)
            {
                if (savedInt == elementsArray[i])
                {
                    equalLength++;
                }
                else
                {
                    savedInt = elementsArray[i];
                    maxEqualLength = maxEqualLength < equalLength ? equalLength : maxEqualLength;
                    equalLength = 1;
                }

            }

            Console.WriteLine(maxEqualLength);
        }
    }
}