using functions;

namespace task7
{
    public class PointInCircle
    {
        public static void Result()
        {
            double x;
            double y;
            string output = "incorect";
            const double RADIUS = 2;

            if (!double.TryParse(Console.ReadLine(), out x)
                || !double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            double result = Functions.PitagorTeorem(x, y);
            output = result <= RADIUS ? "yes " : "no ";

            Console.WriteLine(output + "{0:0.00}", result);
        }
    }
}
