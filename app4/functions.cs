namespace functions
{
    public class Functions
    {
        public static double Factorial(double number)
        {
            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static long FactorialLong(double number)
        {
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public static string Reverse(string input)
        {
            char[] charInput = input.ToCharArray();
            Array.Reverse(charInput);
            return new string(charInput);
        }

        public static double HexToDecDegree(int hex, int degree)
        {
            return hex * Math.Pow(16, degree);
        }
    }
}