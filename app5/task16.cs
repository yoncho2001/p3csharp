using functions;

namespace task16
{
    public class RemoveElementsFromArray
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArr = Functions.InsertIntArr(numberN);

            int[] sortedElementsCounts = new int[elementsArr.Length];

            for (int i = 0; i < elementsArr.Length; i++)
            {
                sortedElementsCounts[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (elementsArr[i] >= elementsArr[j])
                    {
                        sortedElementsCounts[i] = Math.Max(sortedElementsCounts[i], sortedElementsCounts[j] + 1);
                    }
                }
            }
            int maxLength = sortedElementsCounts.Max();

            Console.WriteLine(numberN - maxLength);
        }
    }
}