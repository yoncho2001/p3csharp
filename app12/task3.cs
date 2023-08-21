using functions;

namespace task3
{
    public class CorrectBrackets
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            bool check = true;
            Stack<char> brackets = new Stack<char>();

            if (input == null)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '[':
                    case '{':
                    case '(':
                        brackets.Push(input[i]);
                        break;
                    case ']':
                    case '}':
                    case ')':
                        brackets.Pop();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(brackets.Count == 0);
        }
    }
}