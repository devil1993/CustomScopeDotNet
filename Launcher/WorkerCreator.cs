using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAspNetScopedDependency
{
    public class WorkerCreator
    {
        public static Task CreateProcessorJob(string data)
        {
            return Task.Factory.StartNew((data) =>
            {
                var scope = ScopedProvider.CreateScope();
                //scope.ServiceProvider.GetService<Processor>().Process((string)data);
                Thread.Sleep(5000);
                Console.WriteLine($"Received: {data}\n{Task.CurrentId}");
            }, data);
        }
    }
}
