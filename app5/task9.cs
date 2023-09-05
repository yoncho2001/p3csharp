using functions;

namespace task9
{
    public class FrequentNumber
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArray = Functions.InsertIntArray(numberN);

            Dictionary <int, int> newPairs = new Dictionary<int, int>();
            
            for (int i = 0; i < elementsArray.Length; i++)
            {
                if (newPairs.ContainsKey(elementsArray[i]))
                {
                    newPairs[elementsArray[i]] ++;
                }
                else
                {
                    newPairs.Add(elementsArray[i], 1);
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
