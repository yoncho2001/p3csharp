namespace task2
{
    public class MoonGravity
    {
        public static void Result()
        {
            const  double MOON_GRAVITY_PERCENT = 0.17;
            double weight;

            if(!double.TryParse(Console.ReadLine(), out weight)){
                Console.WriteLine("Incorrect input");
                return ;
            }

            weight *= MOON_GRAVITY_PERCENT;
            Console.WriteLine(String.Format("{0:0.000}", weight));
        }
    }
}