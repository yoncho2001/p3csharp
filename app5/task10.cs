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

            int[] elementsArray = Functions.InsertIntArray(numberN);
            bool foundSubset = false;
            int currentSum = 0;

            for (int i = 0; i < elementsArray.Length; i++)
            {
                for (int j = i; j < elementsArray.Length; j++)
                {
                    currentSum += elementsArray[j];

                    if (currentSum == sumToFind)
                    {
                        output += "\n";
                        output += printSubArray(elementsArray, int i, int j);
                        foundSubset = true;
                    }
                    
                    if (currentSum > sumToFind)
                    {
                        break;
                    }
                }
                currentSum = 0;
            }

            Console.WriteLine(foundSubset ? output : "No Subset Adds To Sum");
        }

        public static string printSubArray(int[] array, int start, int end)
        {
            string output = "";

            for (int i = start; i <= end; i++)
            {
                output += elementsArray[k].ToString() + "\n";
            }
            return output;
        }
    }
}