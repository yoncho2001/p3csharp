using System.IO;
using System.Text.RegularExpressions;
using functions;

namespace task13
{
    public class CountWords

    {
        public static void Result()
        {
            string pathWords = Functions.CanString();
            string pathText = Functions.CanString();
            string pathOut = Functions.CanString();

            try
            {
                Functions.fileExist(pathWords);
                Functions.fileExist(pathText);
                Functions.fileExist(pathOut);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] readText = File.ReadAllLines(pathText);
            using StreamReader file = new StreamReader(pathWords);
            string line = "";

            while ((line = file.ReadLine()) != null)
            {
                words.Add(line, 0);
            }

            for (int i = 0; i < readText.Length; i++)
            {
                MatchCollection wordsLine = Regex.Matches(readText[i], @"\b[\w']*\b");

                foreach(Match match in wordsLine)
                {
                    if (words.ContainsKey(match.Value))
                    {
                        words[match.Value]++;
                    }
                }
            }

            string output = "";

            for (int i = 0; i < words.Count; i++)
            {
                output += "Key: " + words.ElementAt(i).Key + ", Value: " + words.ElementAt(i).Value + "\n";
            }

            File.WriteAllText(pathOut, output);
        }
    }
}
