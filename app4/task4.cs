namespace task4
{
    public class PrintADeck
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string output = "";
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            if (!Array.Exists(cards, element => element == input))
            {
                Console.WriteLine("incorect");
            }


            for (int i = 0; i <= cards.Length; i++)
            {
                if (cards[i] == input)
                {
                    break;
                }
                output += cards[i] + " of spades, " + cards[i] + " of clubs, " + cards[i] + " of hearts, " + cards[i] + " of diamonds\n";
            }
            output += input + " of spades, " + input + " of clubs, " + input + " of hearts, " + input + " of diamonds\n";
            Console.WriteLine(output);
        }
    }
}