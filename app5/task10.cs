using functions;

namespace task10
{
    public class FindSumInArray
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int sumToFind = Functions.CanInt();
            string output = "";

            int[] elementsArr = Functions.InsertIntArr(numberN);
            bool foundSubset = false;
            int currentSum = 0;

            for (int i = 0; i < elementsArr.Length; i++)
            {
                for (int j = i; j < elementsArr.Length; j++)
                {
                    currentSum += elementsArr[j];

                    if (currentSum == sumToFind)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            output += elementsArr[k].ToString() + "\n";
                        }
                        foundSubset = true;
                    }
                    else if (currentSum > sumToFind)
                    {
                        break;
                    }
                }
                currentSum = 0;
            }

            Console.WriteLine(foundSubset ? output : "No Subset Adds To Sum");
        }
    }
}