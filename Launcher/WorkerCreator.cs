using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class WorkerCreator
    {
        public static Task CreateProcessorJob(string data)
        {
            return Task.Factory.StartNew((data) =>
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine($"Received: {data}\n{Task.CurrentId}");
            }, (data));
        }
    }
}
