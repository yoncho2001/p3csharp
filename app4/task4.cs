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

            int index = 0;
            while (cards[index] != input)
            {
                output += cards[index] + " of spades, " + cards[index] + " of clubs, " + cards[index] + " of hearts, " + cards[index] + " of diamonds\n";
                index++;
            }

            output += input + " of spades, " + input + " of clubs, " + input + " of hearts, " + input + " of diamonds\n";
            Console.WriteLine(output);
        }
    }
}