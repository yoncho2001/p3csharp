namespace task7
{
    public class PointInCircle
    {
        public static void Result()
        {
            double x;
            double y;

            if (!double.TryParse(Console.ReadLine(), out x)
                || !double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            const double RADIUS = 2;
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            string output = "incorect";

            if (result <= RADIUS)
            {
                output = "yes";
            }
            else
            {
                output = "no";
            }

            Console.WriteLine(output + "{0:0.00}", result);
        }
    }
}
