namespace task8
{
    public class DigitAsWord

    {
        public static void Result()
        {
            double number;
            string output;

            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            switch (number)
            {
                case 1:
                    output = "one";
                    break;
                case 2:
                    output = "two";
                    break;
                case 3:
                    output = "three";
                    break;
                case 4:
                    output = "four";
                    break;
                case 5:
                    output = "five";
                    break;
                case 6:
                    output = "six";
                    break;
                case 7:
                    output = "seven";
                    break;
                case 8:
                    output = "eight";
                    break;
                case 9:
                    output = "nine";
                    break;
                default:
                    output = "not a digit";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}