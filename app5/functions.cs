namespace functions
{
    public class Functions
    {
        public static int[] InsertIntArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Incorrect input");
                    return array = new int[size];
                }
            }

            return array;
        }

        public static char[] CreateTheAlphabet()
        {
            char[] array = new char[26];

            for (int i = 0; i < 26; i++)
            {
                array[i] += (char)('a' + i);
            }

            return array;
        }

        public static int[] CrateNNuberArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

         public static int CanInt()
        {
            int input;

            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too large or too small");
            }

            return input;
        }

        public static double CanDouble()
        {
            double input;

            try
            {
                input = double.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too large or too small");
            }

            return input;
        }
    }
}