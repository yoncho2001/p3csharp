using System;

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
                    task1.FillTheMatrix.Result();
                    break;
                case "task 2":
                    task2.MaximalSum.Result();
                    break;
                case "task 3":
                    task3.SequenceInMatrix.Result();
                    break;
                case "task 4":
                    task4.BinarySearch.Result();
                    break;
                case "task 5":
                    task5.SortByStringLength.Result();
                    break;
                case "task 6":
                    //task6.Matrix.Result();
                    break;
                case "task 7":
                   task7.NumbersFromOnetoN.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}