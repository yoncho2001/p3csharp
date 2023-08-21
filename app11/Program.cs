using System;
using task6;

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
                    //task1.FillTheMatrix.Result();
                    break;
                case "task 2":
                    //task2.MaximalSum.Result();
                    break;
                case "task 3":
                    //task3.SequenceInMatrix.Result();
                    break;
                case "task 4":
                    task4.BinarySearch.Result();
                    break;
                case "task 5":
                    //task5.SortByStringLength.Result();
                    break;
                case "task 6":
                    Matrix m1 = new Matrix(2, 2, true);
                    Matrix m2 = new Matrix(2, 2, true);

                    Matrix sumResult = m1 + m2;
                    Console.WriteLine("+:\n" + sumResult.ToString());

                    Matrix subtractionResult = m1 - m2;
                    Console.WriteLine("-:\n" + subtractionResult.ToString());

                    Matrix multiplicationResult = m1 * m2;
                    Console.WriteLine("*:\n" + multiplicationResult.ToString());
                    break;
                case "task 7":
                    task7.LargestAreaInMatrix.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}