using functions;

namespace task14
{
    public class HexToDecimal
    {
        public static void Result()
        {
            string insert = Console.ReadLine();
            double resultInDesimal = 0;

            for (int j = (insert.Length - 1); j >= 0; j--)
            {
                switch (insert[j])
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        resultInDesimal += Functions.HexToDecDegree(Int32.Parse(insert[j].ToString()), insert.Length - j - 1);
                        break;
                    case 'A':
                        resultInDesimal += Functions.HexToDecDegree(10, insert.Length - j - 1);
                        break;
                    case 'B':
                        resultInDesimal += Functions.HexToDecDegree(11, insert.Length - j - 1);
                        break;
                    case 'C':
                        resultInDesimal += Functions.HexToDecDegree(12, insert.Length - j - 1);
                        break;
                    case 'D':
                        resultInDesimal += Functions.HexToDecDegree(13, insert.Length - j - 1);
                        break;
                    case 'E':
                        resultInDesimal += Functions.HexToDecDegree(14, insert.Length - j - 1);
                        break;
                    case 'F':
                        resultInDesimal += Functions.HexToDecDegree(15, insert.Length - j - 1);
                        break;
                    default:
                        Console.WriteLine("its not hex value");
                        break;
                }

            }

            Console.WriteLine(resultInDesimal);
        }
    }
}