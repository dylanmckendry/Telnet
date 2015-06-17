using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimS.Telnet.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var client = new TcpClient("192.168.1.29", 1233);
                using (var telnet = new Telnet.Client("192.168.1.56", 1251, CancellationToken.None))
                {
                    var isConnected = telnet.IsConnected;
                    Console.WriteLine(isConnected);
                    Console.ReadKey();
                }

            }
            catch (SocketException exception)
            {
                Console.WriteLine(exception);
                Console.ReadKey();
            }

        }
    }
}
