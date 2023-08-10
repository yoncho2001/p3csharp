using functions;

namespace task9
{
    public class FrequentNumber
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArr = Functions.InsertIntArr(numberN);

            Dictionary <int, int> newPairs = new Dictionary<int, int>();
            
            for (int i = 0; i < elementsArr.Length; i++)
            {
                if (newPairs.ContainsKey(elementsArr[i]))
                {
                    newPairs[elementsArr[i]] ++;
                }
                else
                {
                    newPairs.Add(elementsArr[i], 1);
                }
            }

            int maxRepeatsNumber = 0;
            int maxRepeats = 0;

            foreach (var element in newPairs)
            {
                if (element.Value > maxRepeats)
                {
                    maxRepeatsNumber = element.Key;
                    maxRepeats = element.Value;
                }
            }
            Console.WriteLine(maxRepeatsNumber.ToString() + "(" + maxRepeats + " times)");
        }
    }
}
