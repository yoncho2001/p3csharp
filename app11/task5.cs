using functions;

namespace task5
{
    public class SortByStringLength
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string[] elementsArr = Functions.InsertStringArr(numberN);

            SortStringArrByLength(elementsArr);

            for (int i = 0; i < numberN; i++)
            {
                Console.WriteLine(elementsArr[i]);
            }
        }

        static void SortStringArrByLength(string[] array)
        {
            int indexMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    indexMin = array[indexMin].Length > array[j].Length ? j : indexMin;
                }

                if (indexMin != i)
                {
                    string temp = array[i];
                    array[i] = array[indexMin];
                    array[indexMin] = temp;
                }

                indexMin = i + 1;
            }
        }
    }
}