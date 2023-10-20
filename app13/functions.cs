using System.Text;

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

        public static string[] InsertStringArr(int size)
        {
            string[] arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
                if (arr[i] == null)
                {
                    Console.WriteLine("Incorrect input");
                    return arr = new string[size];
                }
            }

            return arr;
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

        public static string CanString()
        {
            string input = Console.ReadLine(); ;

            if (input == null)
            {
                throw new ArgumentNullException("Null input is not allowed");
            }

            return input;
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

        public static string ReverseStr(string word)
        {
            StringBuilder reverse = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse.Append(word[i]);
                }

            return reverse.ToString();
        }

    }
}