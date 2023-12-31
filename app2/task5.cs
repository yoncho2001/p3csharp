using functions;

namespace task5
{
    public class QuadraticEquation
    {
        public static void Result()
        {
            double number;
            double number2;
            double number3;
            string output;

            if (!double.TryParse(Console.ReadLine(), out number)
                || !double.TryParse(Console.ReadLine(), out number2)
                || !double.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (Functions.DeterminantOnSecondDegree(a, b, c) < 0)
            {
                output = "no real roots";
            }
            else
            {
                double determinant = Math.Sqrt(Functions.DeterminantaOnSecondDegree(a, b, c));
                double root1 = (-number2 + determinant) / (2 * number);
                double root2 = (-number2 - determinant) / (2 * number);
                if (root1 == root2)
                {
                    output = root1.ToString();
                }
                else
                {
                    output = root1.ToString() + "\n";
                    output += root2.ToString();
                }
            }

            Console.WriteLine(output);
        }
    }
}