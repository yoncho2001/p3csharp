namespace functions
{
    public class Functions
    {
        public static int[] InsertIntArr(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Incorrect input");
                    return arr = new int[size];
                }
            }

            return arr;
        }

        public static int CanInt()
        {
            if (!int.TryParse(Console.ReadLine(), out int temp))
            {
                Console.WriteLine("Incorrect input");
                return 0;
            }

            return temp;
        }

        public static double CanDouble()
        {
            if (!double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine("Incorrect input");
                return 0;
            }

            return temp;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            string output = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += matrix[i, j].ToString() + " ";
                }
                output += "\n";
            }

            Console.WriteLine(output);
        }
    }
}