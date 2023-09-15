using System;
using System.Text.RegularExpressions;

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
                throw new ArgumentNullException("Null input is not allowed 555");
            }
        }

        public static void isPhone(string input)
        {
            Regex rg = new Regex(@"^0{1}[1-9][0-9]{8}$|^\+{1}[1-9]{3}[1-9][0-9]{8}$");

            if (input == null || !rg.IsMatch(input))
            {
                throw new ArgumentException("the input is not phone number");
            }
        }

        public static void isEGN(string input)
        {
            Regex rg = new Regex(@"^[0-9]{2}(?:0[1-9]|1[0-2]|2[1-9]|3[0-2]|4[1-9]|5[0-2])(?:0[1-9]|[1-2][0-9]|3[0-1])[0-9]{4}$");

            if (input == null || !rg.IsMatch(input))
            {
                throw new ArgumentException("the input is not EGN number");
            }
        }

        public static void isEIK(string input)
        {
            Regex rg = new Regex(@"\d{9}|\d{13}");

            if (input == null || !rg.IsMatch(input))
            {
                throw new ArgumentException("the input is not EIK number");
            }
        }

        public static void isNotNull(Customer input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }

        public static void isNotNull(List<Acount> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }
    }
}