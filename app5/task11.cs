using functions;

namespace task11
{
    public class BinarySearch
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArr = Functions.InsertIntArr(numberN);
            int numToFind = Functions.CanInt();

            int left = 0;
            int right = elementsArr.Length - 1;
            bool isInside = false;
            int index = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (elementsArr[mid] == numToFind)
                {
                    isInside = true;
                    index = mid;
                    break;
                }
                else if (elementsArr[mid] < numToFind)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(isInside ? index : "Not inside");
        }
    }
}