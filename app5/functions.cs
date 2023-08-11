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

        public static char[] CrateTheAlphabet()
        {
            char[] arr = new char[26];

            for (int i = 0; i < 26; i++)
            {
                arr[i] += (char)('a' + i);
            }

            return arr;
        }

        public static int[] CrateNNuberArr(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1;
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
    }
}