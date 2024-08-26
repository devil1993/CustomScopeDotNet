using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NonAspNetScopedDependency
{
    public static class SocketManager
    {
        public static Socket CreateSocket(IPAddress address, int port)
        {
            IPEndPoint localEndPoint = new IPEndPoint(address, port);
            var socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(localEndPoint);
            return socket;
        }

        public static Socket CreateIPc4Socket()
        {
            return CreateIPc4Socket(23523);
        }

        public static Socket CreateIPc4Socket(int port)
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList.First(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            return CreateSocket(ipAddr, port);
        }
    }
}
