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
                    task1.AllocateArray.Result();
                    break;
                case "task 2":
                    task2.CompareArrays.Result();
                    break;
                case "task 3":
                    task3.CompareCharArrays.Result();
                    break;
                case "task 4":
                    task4.MaximalSequence.Result();
                    break;
                case "task 5":
                    task5.MaximalIncreasingSequence.Result();
                    break;
                case "task 6":
                    task6.MaximalKSum.Result();
                    break;
                case "task 7":
                    task7.SelectionSort.Result();
                    break;
                case "task 8":
                    task8.MaximalSum.Result();
                    break;
                case "task 9":
                    task9.FrequentNumber.Result();
                    break;
                case "task 10":
                    task10.FindSumInArray.Result();
                    break;
                case "task 11":
                    task11.BinarySearch.Result();
                    break;
                case "task 12":
                    task12.IndexOfLetters.Result();
                    break;
                case "task 13":
                    task13.MergeSort.Result();
                    break;
                case "task 14":
                    task14.QuickSort.Result();
                    break;
                case "task 15":
                    task15.PrimeNumbers.Result();
                    break;
                case "task 16":
                    task16.RemoveElementsFromArray.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}