namespace functions
{
    public class Functions
    {
        public static double RadiusOfCircle(double radius)
        {
            const double PI = 3.14;

            return radius * PI * 2;
        }

        public static double AreaOfCircle(double radius)
        {
            const double PI = 3.14;
            
            return Math.Pow(radius, 2) * PI;
        }

        public static double DeterminantOnSecondDegree(double a, double b, double c)
        {
            return (Math.Pow(b, 2) - 4 * a * c);
        }
    }
}