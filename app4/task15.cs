namespace task15
{
    public class GCD
    {
        public static void Result()
        {
            Console.WriteLine("Insert the numbers whit spase bar");
            string insert = Console.ReadLine();
            string[] tokens = insert.Split(" ");
            int[] numbers = new int[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                if (!Int32.TryParse(tokens[i], out int oneNum))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
                numbers[i] = oneNum;
            }

            while (numbers[0] != 0)
            {
                numbers[1] = numbers[1] % numbers[0];
                numbers[0] = numbers[0] + numbers[1];
                numbers[1] = numbers[0] - numbers[1];
                numbers[0] = numbers[0] - numbers[1];

            }

            Console.WriteLine(numbers[1]);
        }
    }
}