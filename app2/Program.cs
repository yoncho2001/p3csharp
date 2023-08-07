using System;
using task1;
using task2;
using task3;
using task4;
using task5;
using task6;
using task7;
using task8;
using task9;
using task10;

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
                case "task 1":
                    task1.SumOfThreeNumbers.Result();
                    break;
                case "task 2":
                    task2.CompanyInfo.Result();
                    break;
                case "task 3":
                    task3.Circle.Result();
                    break;
                case "task 4":
                    task4.NumberComparer.Result();
                    break;
                case "task 5":
                    task5.QuadraticEquation.Result();
                    break;
                case "task 6":
                    task6.SumOfFiveNumbers.Result();
                    break;
                case "task 7":
                    task7.NumbersFromOnetoN.Result();
                    break;
                case "task 8":
                    task8.SumOfNNumbers.Result();
                    break;
                case "task 9":
                    task9.FibonacciNumbers.Result();
                    break;
                case "task 10":
                    task10.Interval.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}