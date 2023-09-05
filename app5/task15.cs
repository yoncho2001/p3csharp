using functions;

namespace task15
{
    public class PrimeNumbers
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArray = Functions.CrateNNuberArray(numberN);
            int[] primeArray = new int[0];
            bool isprime = true;

            for (int i = 1; i < elementsArray.Length; i++)
            {
                for (int j = 0; j < primeArray.Length; j++)
                {
                    if (elementsArray[i] % primeArray[j] == 0)
                    {
                        isprime = false;
                    }
                }

                if (isprime)
                {
                    primeArray = primeArray.Append(elementsArray[i]).ToArray();
                }

                isprime = true;
            }

            Console.WriteLine(primeArray[primeArray.Length - 1]);
        }
    }
}