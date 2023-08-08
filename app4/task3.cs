namespace task3
{
    public class MMSA
    {
        public static void Result()
        {
            double numberOfN;
            double max = 0;
            double min = 0;
            double sum = 0;
            string output = "";

            if (!double.TryParse(Console.ReadLine(), out numberOfN))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (numberOfN != 0)
            {
                if (!int.TryParse(Console.ReadLine(), out int temp))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                max = temp;
                min = temp;
                sum += temp;
            }

            for (int i = 1; i < numberOfN; i++)
            {
                double newNumber;
                if (!double.TryParse(Console.ReadLine(), out newNumber))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                if (max < newNumber)
                {
                    max = newNumber;
                }

                if (min > newNumber)
                {
                    min = newNumber;
                }

                sum += newNumber;
            }
            
            output += "min= " + min.ToString("0.00") + "\n";
            output += "max= " + max.ToString("0.00") + "\n";
            output += "sum= " + sum.ToString("0.00") + "\n";
            output += "avg= " + (sum/numberOfN).ToString("0.00");
            Console.WriteLine(output);
        }
    }
}