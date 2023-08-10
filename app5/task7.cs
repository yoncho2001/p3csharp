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
            int[] elementsArr = Functions.InsertIntArr(numberN);

            for (int i = 0; i < elementsArr.Length; i++)
            {
                for (int j = i; j < elementsArr.Length; j++)
                {
                    indexMin = elementsArr[indexMin] > elementsArr[j] ? j : indexMin;
                }

                if (indexMin != i)
                {
                    elementsArr[i] = elementsArr[i] + elementsArr[indexMin];
                    elementsArr[indexMin] = elementsArr[i] - elementsArr[indexMin];
                    elementsArr[i] = elementsArr[i] - elementsArr[indexMin];
                }

                indexMin = i + 1;
            }

            for (int i = 0; i < elementsArr.Length; i++)
            {
                output += elementsArr[i].ToString() + "\n";
            }

            Console.WriteLine(output);
        }
    }
}