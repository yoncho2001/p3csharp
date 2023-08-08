using functions;

namespace task3
{
    public class Circle
    {
        public static void Result()
        {
            double radius;
            const double PI = 3.14;

            if (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            double perimeterResult = Functions.RadiusOfCircle(radius);
            double areaResult = Functions.AreaOfCircle(radius);
            Console.WriteLine("{0:0.00}" + "\n" + "{1:0.00}", perimeterResult, areaResult);
        }
    }
}