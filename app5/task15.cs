using functions;

namespace task15
{
    public class PrimeNumbers
    {
        public static void Result()
        {
            int numberN = Functions.CanInt();
            int[] elementsArr = Functions.CrateNNuberArr(numberN);
            int[] primeArr = new int[0];
            bool isprime = true;

            for (int i = 1; i < elementsArr.Length; i++)
            {
                for (int j = 0; j < primeArr.Length; j++)
                {
                    if (elementsArr[i] % primeArr[j] == 0)
                    {
                        isprime = false;
                    }
                }

                if (isprime)
                {
                    primeArr = primeArr.Append(elementsArr[i]).ToArray();
                }

                isprime = true;
            }

            Console.WriteLine(primeArr[primeArr.Length - 1]);
        }
    }
}