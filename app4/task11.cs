namespace task11
{
    public class BinaryToDecimal
    {
        public static void Result()
        {
            string insert = Console.ReadLine();
            int[] bits = new int[insert.Length];
            double resultInDesimal = 0;

            for (int i = 0; i < insert.Length; i++)
            {
                if (!Int32.TryParse(insert[i].ToString(), out int oneNum))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
                bits[i] = oneNum;
            }

            for (int j = (bits.Length - 1); j >= 0; j--)
            {
                if (bits[j] == 1)
                {
                    resultInDesimal += Math.Pow(2, bits.Length - j - 1);
                }
            }
            Console.WriteLine(resultInDesimal);
        }
    }
}