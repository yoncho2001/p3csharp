namespace task11
{
    public class ThirdrdBit
    {
        public static void Result()
        {
            int number;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            number &= 4;
            number >>= 2;
            Console.WriteLine(number);
        }
    }
}
