using functions;

namespace task13
{
    public class DecimalToHex
    {
        public static void Result()
        {
            long numberDecimal;
            string output = "";

            if (!long.TryParse(Console.ReadLine(), out numberDecimal))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            while (numberDecimal > 0)
            {
                switch (numberDecimal % 16)
                {
                    case 1:
                        output += "1";
                        break;
                    case 2:
                        output += "2";
                        break;
                    case 3:
                        output += "3";
                        break;
                    case 4:
                        output += "4";
                        break;
                    case 5:
                        output += "5";
                        break;
                    case 6:
                        output += "6";
                        break;
                    case 7:
                        output += "7";
                        break;
                    case 8:
                        output += "8";
                        break;
                    case 9:
                        output += "9";
                        break;
                    case 10:
                        output += "A";
                        break;
                    case 11:
                        output += "B";
                        break;
                    case 12:
                        output += "C";
                        break;
                    case 13:
                        output += "D";
                        break;
                    case 14:
                        output += "E";
                        break;
                    default:
                        output = "F";
                        break;
                }
                numberDecimal /= 16;
            }
            Console.WriteLine(Functions.Reverse(output));
        }
    }
}