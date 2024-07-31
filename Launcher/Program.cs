using Launcher;
using System.Net;
using System.Net.Sockets;
using System.Text;

List<Task> tasks = new List<Task>();
const int numberOfConnections = 1;

using Socket listener = SocketManager.CreateIPc4Socket();

try
{
	listener.Listen(numberOfConnections);
	do
    {
        var createdTask = await HandleConnection(listener, WorkerCreator.CreateProcessorJob, MessageReader.ReadMessage);
        tasks.Add(createdTask);
    } while (true);

}
catch (Exception e)
{
    Console.WriteLine(e.StackTrace);
}
finally
{
    Task.WaitAll(tasks.ToArray());
    listener.Close();
    listener.Dispose();
}

static async Task<Task> HandleConnection(Socket listener, Func<string, Task> executor, Func<Socket, Task<string>> reader)
{
    using var handler = await listener.AcceptAsync();
    var data = await reader(handler);
    var createdTask = executor(data);
    handler.Shutdown(SocketShutdown.Both);
    handler.Close();
    return createdTask;
}