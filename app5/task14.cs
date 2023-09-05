using functions;

namespace task14
{
    public class QuickSort
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string output = "";
            int[] elementsArray = Functions.InsertIntArray(numberN);

            QuickSortFunction(elementsArray, 0, elementsArray.Length - 1);

            for (int i = 0; i < elementsArray.Length; i++)
            {
                output += elementsArray[i].ToString() + "\n";
            }

            Console.WriteLine(output);
        }

        public static int SortElement(int[] arr, int left, int right)
        {
            int element = arr[right];
            int index = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < element)
                {
                    index++;
                    int temp = arr[index];
                    arr[index] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[index + 1];
            arr[index + 1] = arr[right];
            arr[right] = temp1;

            return index + 1;
        }

        public static void QuickSortFunction(int[] array, int left, int right)
        {
            if (left < right)
            {
                int sortedElementIndex = SortElement(array, left, right);

                QuickSortFunction(array, left, sortedElementIndex - 1);
                QuickSortFunction(array, sortedElementIndex + 1, right);
            }
        }

    }
}