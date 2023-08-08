namespace task3
{
    public class PlayCard
    {
        public static void Result()
        {
            string card = Console.ReadLine();
            string outcome;

            switch (card)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    outcome = "yes " + card;
                    break;
                default:
                    outcome = "no " + card;
                    break;
            }

            /* we can use array also
                outcome = Array.Exists(cards, elem => elem == card) ? "yes " : "no ";
                outcome += card;*/

            Console.WriteLine(outcome);
        }
    }
}