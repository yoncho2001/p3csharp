namespace task9
{
    public class IntDoubleString
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            string output = "";

            switch (input)
            {
                case "integer":
                    int numberInt;

                    if (!int.TryParse(Console.ReadLine(), out numberInt))
                    {
                        Console.WriteLine("Incorrect input");
                        return;
                    }

                    output = (numberInt + 1).ToString();
                    break;
                case "real":
                    double numberDb;

                    if (!double.TryParse(Console.ReadLine(), out numberDb))
                    {
                        Console.WriteLine("Incorrect input");
                        return;
                    }

                    output = (numberDb + 1).ToString();
                    break;
                case "text":
                    string inputText = Console.ReadLine();
                    output += inputText + "*";
                    break;
                default:
                    output = "incorect";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}