using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string text = client.DownloadString(@"http://resources.finance.ua/ua/public/currency-cash.json");

            Console.WriteLine(text);
        }
    }
}
