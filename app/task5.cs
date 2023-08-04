namespace task5
{
    public class ThirdDigit
    {
        public static void Result()
        {
            int widht;

            if (!int.TryParse(Console.ReadLine(), out widht))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            const int THIRD_D = 7;
            widht %= 1000;

            if (widht / 100 == THIRD_D)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + widht / 100);
            }
        }
    }
}