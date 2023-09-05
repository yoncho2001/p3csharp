using System;
using task4;

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
                    task1.SquareRoot.Result();
                    break;
                case "task 2":
                    task2.EnterNumbers.Result();
                    break;    
                case "task 3":
                    task3.ReadFileContents.Result();
                    break;
                case "task 4":
                    task4.FileDownloader.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}