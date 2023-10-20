using functions;

namespace task3
{
    public class CompareCharArrays
    {
        public static void Result()
        {
            string output = "";
            string firstS = Console.ReadLine();
            string secondS = Console.ReadLine();
            int size;
            bool isEqual = true;

            size = firstS.Length <= secondS.Length ? firstS.Length : secondS.Length;

            for (int i = 0; i < size; i++)
            {
                if (firstS[i] < secondS[i])
                {
                    output = "<";
                    isEqual = false;
                    break;
                }
                else if (firstS[i] > secondS[i])
                {
                    secondS = ">";
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                if (firstS.Length != secondS.Length)
                {
                    output = firstS.Length < secondS.Length ? "<" : ">";
                }
                else
                {
                   output = "=";
                }
            }

            Console.WriteLine(output);

        }
    }
}