using functions;

namespace task13
{
    public class MergeSort
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string output = "";
            int[] elementsArray = Functions.InsertIntArray(numberN);

            Sort(elementsArray, 0, elementsArray.Length - 1);

            for (int i = 0; i < elementsArray.Length; i++)
            {
                output += elementsArray[i].ToString() + "\n";
            }

            Console.WriteLine(output);
        }

        public static void Merge(int[] array, int left, int midle, int right)
        {
            int sizeOfLeft = midle - left + 1;
            int sizeOfRight = right - midle;

            int[] leftArray = new int[sizeOfLeft];
            int[] rightArray = new int[sizeOfRight];
            int indexL, indexR;

            for (indexL = 0; indexL < sizeOfLeft; indexL++)
            {
                leftArray[indexL] = array[left + indexL];
            }

            for (indexR = 0; indexR < sizeOfRight; indexR++)
            {
                rightArray[indexR] = array[midle + 1 + indexR];
            }

            indexL = 0;
            indexR = 0;
            int mergeIndex = left;

            while (indexL < sizeOfLeft && indexR < sizeOfRight)
            {
                if (leftArray[indexL] <= rightArray[indexR])
                {
                    array[mergeIndex] = leftArray[indexL];
                    indexL++;
                }
                else
                {
                    array[mergeIndex] = rightArray[indexR];
                    indexR++;
                }
                mergeIndex++;
            }

            while (indexL < sizeOfLeft)
            {
                array[mergeIndex] = leftArray[indexL];
                indexL++;
                mergeIndex++;
            }

            while (indexR < sizeOfRight)
            {
                array[mergeIndex] = rightArray[indexR];
                indexR++;
                mergeIndex++;
            }
        }

        public static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int midle = left + (right - left) / 2;

                Sort(array, left, midle);
                Sort(array, midle + 1, right);

                Merge(array, left, midle, right);
            }
        }
    }
}