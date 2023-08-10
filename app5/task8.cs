using functions;

namespace task8
{
    public class MaximalSum
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArr = Functions.InsertIntArr(numberN);

            int maxSum = elementsArr[0];
            int currentSum = 0;

            foreach (int element in elementsArr)
            {
                currentSum = Math.Max(element, currentSum + element);
                maxSum = Math.Max(maxSum, currentSum);
            }

            Console.WriteLine(maxSum);
        }
    }
}
