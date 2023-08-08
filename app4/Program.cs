using System;
using task1;

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
                    task1.NumbersFromOneToN.Result();
                    break;
                case "task 2":
                    task2.NotDivisibleNumbers.Result();
                    break;
                case "task 3":
                    task3.MMSA.Result();
                    break;
                case "task 4":
                    task4.PrintADeck.Result();
                    break;
                case "task 5":
                    task5.Calculate.Result();
                    break;
                case "task 7":
                  //  task7.SortThreeNumbers.Result();
                    break;
                case "task 8":
                  //  task8.DigitAsWord.Result();
                    break;
                case "task 9":
                 //   task9.IntDoubleString.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}