using System;


namespace task1
{
    public class OddOrEven
    {
        public static void Result()
        {
            Console.WriteLine("Your number = ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even" + " " + number);
            }
            else
            {
                Console.WriteLine("odd" + " " + number);
            }
        }
    }
}

namespace task2
{
    public class MoonGravity
    {
        public static void Result()
        {
            const double procent = 0.17;
            double weight = Convert.ToDouble(Console.ReadLine()) * procent;
            Console.WriteLine(String.Format("{0:0.000}", weight));

        }
    }
}

namespace task3
{
    public class DivideBy7And5
    {
        public static void Result()
        {

            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("true" + " " + number);
            }
            else
            {
                Console.WriteLine("false" + " " + number);
            }

        }
    }
}

namespace task4
{
    public class Rectangles
    {
        public static void Result()
        {
            double widht = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());

            double area = widht * height;
            double perimeter = widht * 2 + height * 2;

            Console.WriteLine(String.Format("{0:0.00} {1:0.00}", area, perimeter));

        }
    }
}

namespace task5
{
    public class ThirdDigit
    {
        public static void Result()
        {
            int widht = Convert.ToInt32(Console.ReadLine());
            widht %= 1000; 
            if (widht/100 == 7 )
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + widht/100);
            }
        }
    }
}

namespace task6
{
    public class FourDigits
    {
        public static void Result()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            number %= 1000;

            int b = number / 100;
            number %= 100;

            int c = number / 10;
            number %= 10;
            int d = number;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine(Convert.ToString(d) + Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(a));
            Console.WriteLine(Convert.ToString(d) + Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c));
            Console.WriteLine(Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(d));
        }
    }
}

namespace MainNS
{
    static class Program
    {
        static void Main()
        {
            // task1.OddOrEven.Result();
            // task2.MoonGravity.Result();
            // task3.DivideBy7And5.Result();
            // task4.Rectangles.Result();
            // task5.ThirdDigit.Result();
            task6.FourDigits.Result();  

        }
    }
}