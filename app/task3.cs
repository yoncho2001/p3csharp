namespace task3
{
    public class DivideBy7And5
    {
        public static void Result()
        {
            int number;
            
            if(!int.TryParse(Console.ReadLine(), out number)){
                Console.WriteLine("Incorrect input");
                return ;
            }
            Console.WriteLine((number % 5 == 0 && number % 7 == 0).ToString() + " " + number);
        }
    }
}