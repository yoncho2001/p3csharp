namespace task2
{
    public class MoonGravity
    {
        public static void Result()
        {
            const  double PERCENT = 0.17;
            double weight;

            if(!double.TryParse(Console.ReadLine(), out weight)){
                Console.WriteLine("Incorrect input");
                return ;
            }

            weight *= PERCENT;
            Console.WriteLine(String.Format("{0:0.000}", weight));
        }
    }
}