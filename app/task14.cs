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
            string partP = output.Substring(output.Length - p - k, k);
            string partQ = output.Substring(output.Length - q - k, k);
            output = output.Remove(output.Length - p - k, k).Insert(output.Length - p - k, partQ);
            output = output.Remove(output.Length - q - k, k).Insert(output.Length - q - k, partP);
            Console.WriteLine(Convert.ToInt32(output.ToString(), 2));
        }
    }
}