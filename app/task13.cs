using System.Text;

namespace task13
{
    public class ModifyBit
    {
        public static void Result()
        {
            int number;
            int position;
            int bitValue;

            if (!int.TryParse(Console.ReadLine(), out number)
                || !int.TryParse(Console.ReadLine(), out position)
                || !int.TryParse(Console.ReadLine(), out bitValue))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (bitValue == 1)
            {
                bitValue <<= position;
                number |= bitValue;
            }
            else
            {
                bitValue = 1;
                bitValue <<= position;
                bitValue = ~bitValue;
                number &= bitValue;
            }

            Console.WriteLine(number);
        }
    }
}