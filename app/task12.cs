namespace task12
{
    public class NthBit
    {
        public static void Result()
        {
            int number ;
            int Nbit ;

            if(!int.TryParse(Console.ReadLine(), out number)
                || !int.TryParse(Console.ReadLine(), out Nbit))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int bitBr = 1;
            bitBr <<= Nbit - 1;
            number &= bitBr;
            number >>= Nbit - 1;
            Console.WriteLine(number);
        }
    }   
}