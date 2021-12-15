using Microsoft.Extensions.Hosting;
using WebApplication1;
using WpfLibrary1;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWpf()
                .ConfigureWpfInvoker();
    }
}
