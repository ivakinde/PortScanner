using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PortScanner
{
    static class Host
    {
        //define socket variables
        public static int port { set; get; }
        public static string host { set; get; }

        //define method Socket.Connect
        public static string Connect(string proto_type)
        {
            try
            {
                    IPAddress[] IPs = Dns.GetHostAddresses(host);
                    Socket s = null;
                    if (proto_type == "tcp")
                    {
                        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    }
                    else
                    {
                        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    }
                    s.Connect(IPs[0], port);
                    string output_tcp = String.Format("{0} - Connection established", host);
                    return output_tcp;

               
            }
            catch (ArgumentOutOfRangeException e)
            {
                string output = String.Format("Wrong port");
                return output;
            }
            catch (SocketException e)
            {
                string output = String.Format("{0} - The port couldn't be opened", host);
                return output;
            }
         }
    }
}