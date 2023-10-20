using functions;

namespace task16
{
    public class RemoveElementsFromArray
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArray = Functions.InsertIntArray(numberN);
            int[] sortedElementsCounts = new int[elementsArray.Length];

            for (int i = 0; i < elementsArray.Length; i++)
            {
                sortedElementsCounts[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (elementsArray[i] >= elementsArray[j])
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