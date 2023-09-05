using functions;

namespace task5
{
    public class MaximalIncreasingSequence
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int increasingLength = 1;
            int maxIncreasingLength = 0;
            int savedInt;

            int[] elementsArray =  Functions.InsertIntArray(numberN);
            savedInt = elementsArray[0];

            for (int i = 1; i < elementsArray.Length; i++)
            {
                if (savedInt == elementsArray[i]-1)
                {
                    increasingLength++;
                    savedInt = elementsArray[1];
                }
                else
                {
                    savedInt = elementsArray[i];
                    maxIncreasingLength = maxIncreasingLength < increasingLength? increasingLength : maxIncreasingLength ;
                    increasingLength = 1;
                }
                
            }
            Console.WriteLine(maxIncreasingLength);
        }
    }
}