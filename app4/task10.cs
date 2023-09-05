namespace task10
{
    public class OddAndEvenProduct
    {
        public static void Result()
        {
            int numberN;
            int valueOdd = 1;
            int valueEven = 1;
            string output = "";

            if (!int.TryParse(Console.ReadLine(), out numberN))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine("Insert the numbers whit spacebar");
            string insert = Console.ReadLine();
            string[] tokens = insert.Split(" ");
            int[] numbers = new int[numberN];

            for (int i = 0; i < numberN; i++)
            {
                if (!Int32.TryParse(tokens[i], out int oneNum))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
                numbers[i] = oneNum;
            }

            for (int i = 0; i < numberN; i++)
            {
                if (i % 2 == 0)
                {
                    valueOdd *= numbers[i];
                }
                else
                {
                    valueEven *= numbers[i];
                }
            }

            output = valueOdd == valueEven ? "yes " + valueOdd.ToString() : "no " + valueOdd.ToString() + " " + valueEven.ToString();
            Console.WriteLine(output);
        }
    }
}