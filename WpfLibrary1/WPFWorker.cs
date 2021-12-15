using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace WpfLibrary1
{
    public class WPFWorker : BackgroundService
    {
        private IHostApplicationLifetime hostApplicationLifetime;

        private TaskCompletionSource tcs = new TaskCompletionSource();

        public WPFWorker(IHostApplicationLifetime hostApplicationLifetime)
        {
            this.hostApplicationLifetime = hostApplicationLifetime;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Thread wpfThread = new Thread(new ThreadStart(StartWpf));
            wpfThread.SetApartmentState(ApartmentState.STA);
            wpfThread.Start();
            return this.tcs.Task;
        }

        private void StartWpf()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
            this.tcs.SetResult();
            this.hostApplicationLifetime.StopApplication();
        }
    }
}
