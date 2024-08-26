using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NonAspNetScopedDependency
{
    public class MessageReader
    {
        public static async Task<string> ReadMessage(Socket connection)
        {
            string data = string.Empty;
            int numByte;
            do
            {
                byte[] bytes = new byte[1024];
                numByte = await connection.ReceiveAsync(bytes);
                if (numByte <= 0)
                    break;

                data += Encoding.ASCII.GetString(bytes, 0, numByte);

            } while (numByte == 1024);
            return data;
        }
    }
}
