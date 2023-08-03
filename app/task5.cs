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

            widht %= 1000;

            if (widht / 100 == 7)
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