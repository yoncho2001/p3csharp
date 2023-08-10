using functions;

namespace task6
{
    public class MaximalKSum
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int numberK = Functions.CanInt();
            int kSum = 0;
            int maxkSum = 0;

            int[] elementsArr = Functions.InsertIntArr(numberN);

            for (int i = 0; i <= elementsArr.Length - numberK; i++)
            {
                for (int j = 0; j < numberK; j++)
                {
                    kSum += elementsArr[i + j];
                }

                maxkSum = maxkSum < kSum ? kSum : maxkSum;
                kSum = 0;
            }
            Console.WriteLine(maxkSum);
        }
    }
}