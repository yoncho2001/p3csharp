using System;
using task1;
using task2;
using task3;
using task4;
using task5;
using task7;
using task8;

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
                    task1.ExchangeNumbers.Result();
                    break;
                case "task 2":
                    task2.BonusScore.Result();
                    break;
                case "task 3":
                    task3.PlayCard.Result();
                    break;
                case "task 4":
                    task4.MultiplicationSign.Result();
                    break;
                case "task 5":
                    task5.BiggestOfFive.Result();
                    break;
                case "task 7":
                    task7.SortThreeNumbers.Result();
                    break;
                case "task 8":
                    task8.DigitAsWord.Result();
                    break;
                case "task 9":
                    task9.IntDoubleString.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}