using Microsoft.AspNetCore.Mvc;
using WpfLibrary1;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        [HttpDelete]
        public IActionResult ShutdownApplication()
        {
            App.Current.Dispatcher.Invoke(() => App.Current.Shutdown());
            return NoContent();
        }
    }
}
