using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Validate
    {
        public static void isPositive(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("cannot be negative.");
            }
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

        public static void isNull(List<Discipline> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }
        public static void isNull(List<Student> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }

        public static void isNull(List<Teacher> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }

        public static void isNull(Discipline input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }

        public static void isNull(List<Class> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
        }
    }
}
