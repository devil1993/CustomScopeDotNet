using System.Net;
using System.Net.Sockets;
using System.Text;

IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
IPAddress ipAddr = new IPAddress([127,0,0,1]);
IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 23523);

Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

List<Task> tasks = new List<Task>();

try
{
	listener.Bind(localEndPoint);
	listener.Listen(20);

	do
	{
        var handler= await listener.AcceptAsync();
        string data = string.Empty;
        int numByte;
        do
        {
            byte[] bytes = new Byte[1024];
            numByte = await handler.ReceiveAsync(bytes);
            if (numByte <= 0)
                break;

            data += Encoding.ASCII.GetString(bytes, 0, numByte);

        }while(numByte == 1024);
        var createdTask = Task.Factory.StartNew((data) => {
            Thread.Sleep(5000);
            Console.WriteLine($"Received: {data}");
        }, (data));
        tasks.Add(createdTask);
        handler.Shutdown(SocketShutdown.Both);
        handler.Close();
    } while (true);

}
catch (Exception e)
{
    Console.WriteLine(e.StackTrace);
}
