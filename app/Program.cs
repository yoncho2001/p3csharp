using System;
using task6;
using task7;
using task8;
using task9;
using task10;
using task11;
using task12;

namespace MainNS
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Input the task: ");
            string? tasks = Console.ReadLine();

            if (string.IsNullOrEmpty(tasks))
            {
                Console.WriteLine("Incorrect input");
                return;
            }


            switch (tasks)
            {
                case "task 6":
                    task6.FourDigits.Result();
                    break;
                case "task 7":
                    task7.PointInCircle.Result();
                    break;
                case "task 8":
                    task8.PrimeCheck.Result();
                    break;
                case "task 9":
                    task9.Trapezoids.Result();
                    break;
                case "task 10":
                    task10.PointCircleRectangle.Result();
                    break;
                case "task 11":
                    task11.ThirdrdBit.Result();
                    break;
                case "task 12":
                    task12.NthBit.Result();
                    break;
                case "task 13":
                    task13.ModifyBit.Result();
                    break;
                case "task 14":
                    task14.BitSwap.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }

        }
    }
}