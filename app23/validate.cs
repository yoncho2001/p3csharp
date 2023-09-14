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

        public static void isGrade(int input)
        {
            if (input < 0 || input > 12)
            {
                throw new ArgumentException("cannot be negative or above 12.");
            }
        }

        public static void isPositive(int input)
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

        /*public static void isNull(Battery input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }   */     
    }
}