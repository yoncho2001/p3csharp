namespace task9
{
    public class Trapezoids
    {
        public static void Result()
        {
            double a;
            double b;
            double h;

            if (!double.TryParse(Console.ReadLine(), out a)
                || !double.TryParse(Console.ReadLine(), out b)
                || !double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine("{0:0.0000000}", (a + b) * h / 2);
        }
    }
}