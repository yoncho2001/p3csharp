namespace task4
{
    public class Rectangles
    {
        public static void Result()
        {
            double widht;
            double height;

            if (!double.TryParse(Console.ReadLine(), out widht)
                || !double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            double area = widht * height;
            double perimeter = widht * 2 + height * 2;
            Console.WriteLine(String.Format("{0:0.00} {1:0.00}", area, perimeter));
        }
    }
}