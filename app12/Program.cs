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
                case "task 2":
                    task2.ReversString.Result();
                    break;
                case "task 3":
                    task3.CorrectBrackets.Result();
                    break;
                case "task 4":
                    task4.SubStringinText.Result();
                    break;
                case "task 5":
                    task5.ParseTags.Result();
                    break;
                case "task 6":
                    task6.StringLength.Result();
                    break;
                case "task 7":
                    task7.EncodeDecode.Result();
                    break;
                case "task 8":
                    task8.ExtractSentences.Result();
                    break;
                case "task 9":
                    task9.ForbiddenWords.Result();
                    break;
                case "task 10":
                    task10.UnicodeCharacters.Result();
                    break;
                case "task 11":
                    task11.FormatNumber.Result();
                    break;
                case "task 12":
                    task12.ParseURL.Result();
                    break;
                case "task 13":
                    task13.ReverseSentence.Result();
                    break;
                case "task 14":
                    task14.WordDictionary.Result();
                    break;
                case "task 15":
                    task15.ReplaceTags.Result();
                    break;
                case "task 16":
                    task16.DateDifference.Result();
                    break;
                case "task 17":
                    task17.DateInBulgarian.Result();
                    break;
                case "task 18":
                    task18.ExtractEmails.Result();
                    break;
                case "task 19":
                    //task19.SortByStringLength.Result();
                    break;
                case "task 20":
                    //task20.LargestAreaInMatrix.Result();
                    break;
                case "task 21":
                    //task21.LargestAreaInMatrix.Result();
                    break;
                case "task 22":
                    //task23.FillTheMatrix.Result();
                    break;
                case "task 24":
                    //task24.MaximalSum.Result();
                    break;
                case "task 25":
                    //task25.SequenceInMatrix.Result();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}