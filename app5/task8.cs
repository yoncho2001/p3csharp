using functions;

namespace task8
{
    public class MaximalSum
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArray = Functions.InsertIntArray(numberN);

            int maxSum = elementsArray[0];
            int currentSum = 0;

            for (int i = 0; i < elementsArray.Length; i++)
            {
                currentSum = Math.Max(elementsArray[i], currentSum + elementsArray[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            Console.WriteLine(maxSum);
        }
    }
}
