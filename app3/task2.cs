namespace task2
{
    public class BonusScore
    {
        public static void Result()
        {
            int score;
            string outcome;

            if (!int.TryParse(Console.ReadLine(), out score))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (score >= 1 && score <= 3)
            {
                outcome = (score * 10).ToString();
            }

            else if (score >= 4 && score <= 6)
            {
                outcome = (score * 100).ToString();
            }

            else if (score >= 7 && score <= 9)
            {
                outcome = (score * 1000).ToString();
            }

            else
            {
                outcome = "invalid score";
            }

            Console.WriteLine(outcome);
        }
    }
}