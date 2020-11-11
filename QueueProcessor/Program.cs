using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace QueueProcessor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddAzureStorage();
            });
            builder.ConfigureLogging((context, b) =>
            {
                b.AddConsole();
            });
            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }
    }
}
