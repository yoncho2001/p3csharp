using System.Text;

namespace task14
{
    public class BitSwap
    {
        public static void Result()
        {
            long n;
            int p;
            int q;
            int k;

            if (!long.TryParse(Console.ReadLine(), out n)
                || !int.TryParse(Console.ReadLine(), out p)
                || !int.TryParse(Console.ReadLine(), out q)
                || !int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            StringBuilder bitString = new StringBuilder(Convert.ToString(n, 2));
            string output = bitString.ToString();
            int indexP = output.Length - p - k;
            int indexQ = output.Length - q - k;

            string partP = output.Substring(indexP, k);
            string partQ = output.Substring(indexQ, k);
            output = output.Remove(indexP, k).Insert(indexP, partQ);
            output = output.Remove(indexQ, k).Insert(indexQ, partP);
            Console.WriteLine(Convert.ToInt32(output.ToString(), 2));
        }
    }
}