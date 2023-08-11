using functions;

namespace task13
{
    public class MergeSort
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            string output = "";
            int[] elementsArr = Functions.InsertIntArr(numberN);

            Sort(elementsArr, 0, elementsArr.Length - 1);

            for (int i = 0; i < elementsArr.Length; i++)
            {
                output += elementsArr[i].ToString() + "\n";
            }

            Console.WriteLine(output);
        }

        public static void Merge(int[] arr, int left, int midle, int right)
        {
            int sizeOfLeft = midle - left + 1;
            int sizeOfRight = right - midle;

            int[] leftArr = new int[sizeOfLeft];
            int[] rightArr = new int[sizeOfRight];
            int indexL, indexR;

            for (indexL = 0; indexL < sizeOfLeft; indexL++)
                leftArr[indexL] = arr[left + indexL];

            for (indexR = 0; indexR < sizeOfRight; indexR++)
                rightArr[indexR] = arr[midle + 1 + indexR];

            indexL = 0;
            indexR = 0;
            int mergeIndex = left;

            while (indexL < sizeOfLeft && indexR < sizeOfRight)
            {
                if (leftArr[indexL] <= rightArr[indexR])
                {
                    arr[mergeIndex] = leftArr[indexL];
                    indexL++;
                }
                else
                {
                    arr[mergeIndex] = rightArr[indexR];
                    indexR++;
                }
                mergeIndex++;
            }

            while (indexL < sizeOfLeft)
            {
                arr[mergeIndex] = leftArr[indexL];
                indexL++;
                mergeIndex++;
            }

            while (indexR < sizeOfRight)
            {
                arr[mergeIndex] = rightArr[indexR];
                indexR++;
                mergeIndex++;
            }
        }

        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int midle = left + (right - left) / 2;

                Sort(arr, left, midle);
                Sort(arr, midle + 1, right);

                Merge(arr, left, midle, right);
            }
        }
    }
}