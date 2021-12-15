using Microsoft.AspNetCore.Mvc;
using System;
using WpfLibrary1;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainWindowController : ControllerBase
    {
        private IServiceProvider serviceProvider;

        public MainWindowController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        [HttpPost]
        public ActionResult<object> ShowMainWindow(MainWindowParameter parameter)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                var mainWin = (MainWindow)this.serviceProvider.GetService(typeof(MainWindow));
                mainWin.Message = parameter.Message;
                mainWin.Show();
            });
            return this.Ok();
        }
    }

    public class MainWindowParameter
    {
        public string Message { get; set; }
    }
}
