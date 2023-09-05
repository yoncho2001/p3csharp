using functions;

namespace task7
{
    public class SelectionSort
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int indexMin = 0;
            string output = "";
            int[] elementsArray = Functions.InsertIntArray(numberN);

            for (int i = 0; i < elementsArray.Length; i++)
            {
                for (int j = i; j < elementsArray.Length; j++)
                {
                    indexMin = elementsArray[indexMin] > elementsArray[j] ? j : indexMin;
                }

                if (indexMin != i)
                {
                    elementsArray[i] = elementsArray[i] + elementsArray[indexMin];
                    elementsArray[indexMin] = elementsArray[i] - elementsArray[indexMin];
                    elementsArray[i] = elementsArray[i] - elementsArray[indexMin];
                }

                indexMin = i + 1;
            }

            for (int i = 0; i < elementsArray.Length; i++)
            {
                output += elementsArray[i].ToString() + "\n";
            }

            Console.WriteLine(output);
        }
    }
}