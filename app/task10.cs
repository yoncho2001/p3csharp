using functions;

namespace task10
{
    public class PointCircleRectangle
    {
        public static void Result()
        {
            double x;
            double y;
            string output = "";

            if (!double.TryParse(Console.ReadLine(), out x)
                || !double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            bool inCircle = false;
            bool inRectangle = false;

            const double CIRCLE_X = 1;
            const double CIRCLE_Y = 1;
            const double CIRCLE_R = 1.5;

            const double TOP_RECTANGLE = 1;
            const double LEFT_RECTANGLE = -1;
            const double WIDTH_RECTANGLE = 6;
            const double HEIGHT_RECTANGLE = 2;

            double result = Functions.PitagorTeorem(x - CIRCLE_X, y - CIRCLE_Y);

            if (result <= CIRCLE_R)
            {
                inCircle = true;
            }

            if ((y <= TOP_RECTANGLE && y >= TOP_RECTANGLE - HEIGHT_RECTANGLE)
                && (x >= LEFT_RECTANGLE && x <= LEFT_RECTANGLE + WIDTH_RECTANGLE))
            {
                inRectangle = true;
            }

            output += inCircle ? "inside circle " : "outside circle ";
            output += inRectangle ? "inside rectangle" : "outside rectangle";
            Console.WriteLine(output);
        }
    }
}