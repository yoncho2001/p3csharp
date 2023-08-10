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
            bool isFirstBiger = true;

            if (firstS.Length != secondS.Length)
            {
                size = firstS.Length < secondS.Length ? firstS.Length : secondS.Length;
            }
            else
            {
                size = secondS.Length;
            }

            for (int i = 0; i < size; i++)
            {
                if (firstS[i] != secondS[i])
                {
                    isEqual = false;
                    isFirstBiger = firstS[i] > secondS[i];
                    break;
                }
            }

            if (isEqual)
            {
                if (size == firstS.Length && size == secondS.Length)
                {
                    output = "=";
                }
                else
                {
                    output = isFirstBiger ? "<" : ">";
                }
            }
            else
            {
                output = isFirstBiger ? ">" : "<";
            }

            Console.WriteLine(output);
        }
    }
}