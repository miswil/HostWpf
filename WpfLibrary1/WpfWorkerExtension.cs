using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WpfLibrary1
{
    public static class WpfWorkerExtension
    {
        public static IHostBuilder ConfigureWpf(this IHostBuilder hostBuilder)
            => hostBuilder.ConfigureServices((hostContext, services) =>
                services.AddTransient<MainWindow>()
                        .AddHostedService<WPFWorker>());
    }
}
