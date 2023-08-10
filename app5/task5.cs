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

            int[] elementsArr =  Functions.InsertIntArr(numberN);
            savedInt = elementsArr[0];

            for (int i = 1; i < elementsArr.Length; i++)
            {
                if (savedInt == elementsArr[i]-1)
                {
                    increasingLength++;
                    savedInt = elementsArr[1];
                }
                else
                {
                    savedInt = elementsArr[i];
                    maxIncreasingLength = maxIncreasingLength < increasingLength? increasingLength : maxIncreasingLength ;
                    increasingLength = 1;
                }
                
            }
            Console.WriteLine(maxIncreasingLength);
        }
    }
}