using System;

namespace validate
{
    public class Validate
    {
        public static int CanInt()
        {
            int input;

            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too large or too small");
            }

            return input;
        }

        public static int CanInt(string input)
        {
            int value;

            try
            {
                value = int.Parse(input);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too large or too small");
            }

            return value;
        }

        public static void isPositive(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("cannot be negative.");
            }
        }

        public static double CanDouble(string input)
        {
            double value;

            try
            {
                value = double.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too large or too small");
            }

            return value;
        }

        public static double CanDouble()
        {
            double input;

            try
            {
                input = double.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too large or too small");
            }

            return input;
        }

        public static void isPositive(double input)
        {
            if (input < 0)
            {
                throw new ArgumentException("cannot be negative.");
            }
        }

        public static string CanString()
        {
            string input = Console.ReadLine(); ;

            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }

            return input;
        }

        public static void isString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }

        public static void FileExist(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    throw new ArgumentException("The file dont exist or can't find the drectory.");
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("The file don't exist.");
            }
        }
    }
}