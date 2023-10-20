using functions;

namespace task4
{
    public class BinarySearch
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArr = Functions.InsertIntArr(numberN);
            int maxKNumber;

            Console.WriteLine("Insert K: ");
            int numberK = Functions.CanInt();

            Array.Sort(elementsArr);
            int index = Array.BinarySearch(elementsArr, numberK);
            maxKNumber = 0 < index ? elementsArr[index] : elementsArr[Math.Abs(index) - 2];

            Console.WriteLine(maxKNumber);
        }
    }
}