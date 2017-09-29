using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Ten Mien:");
            String host = Console.ReadLine();
            IPHostEntry ipHE = Dns.GetHostEntry(host);
            Console.WriteLine("HostName: {0}", ipHE.HostName);

            foreach (string s in ipHE.Aliases)
            {
                Console.WriteLine("\t+Alias: {0} \n", s);
            }
            foreach (IPAddress i in ipHE.AddressList)
            {
                Console.WriteLine("\t+ IP: {0}", i);
            }
            Console.ReadLine();
        }
    }
}
