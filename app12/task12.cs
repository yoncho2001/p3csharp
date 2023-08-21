using functions;
using System.Text;

namespace task12
{
    public class ParseURL
    {
        public static void Result()
        {
            string inputURL = Console.ReadLine();
            string output = "";

            int protocolEnd = inputURL.IndexOf("://");
            
            if (protocolEnd < 0)
            {
                Console.WriteLine("Invalid URL!");
                return;
            }

            string protocol = inputURL.Substring(0, protocolEnd);
           output += "[protocol] = " + protocol + "\n";

            int serverStart = protocolEnd + 3;
            int serverEnd = inputURL.IndexOf('/', serverStart);

            string server = inputURL.Substring(serverStart, serverEnd - serverStart);
            output += "[server] = " + server + "\n";

            string resource = inputURL.Substring(serverEnd);
            output += "[resource] = " + resource;
            
            Console.WriteLine(output);
        }
    }
}