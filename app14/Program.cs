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
                    task1.OddLines.Result();
                    break;
                case "task 2":
                    task2.ConcatenateTextFiles.Result();
                    break;    
                case "task 3":
                    task3.LineNumbers.Result();
                    break;
                case "task 4":
                    task4.CompareTextFiles.Result();
                    break;
                case "task 5":
                    task5.MaximalAreaSum.Result();
                    break;
                case "task 6":
                    task6.SaveSortedNames.Result();
                    break;    
                case "task 7":
                    task7.ReplaceSubString.Result();
                    break;
                case "task 8":
                    task8.ReplaceWholeWord.Result();
                    break;
                case "task 9":
                    task9.DeleteOddLines.Result();
                    break;
                case "task 10":
                  //  task10.ConcatenateTextFiles.Result();
                    break;    
                case "task 11":
                  //  task11.LineNumbers.Result();
                    break;
                case "task 12":
                  //  task12.CompareTextFiles.Result();
                    break;
                case "task 13":
                  //  task13.CompareTextFiles.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}