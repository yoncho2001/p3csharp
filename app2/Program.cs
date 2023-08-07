using System;
using task1;
using task2;
using task3;
using task4;
using task5;

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
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}