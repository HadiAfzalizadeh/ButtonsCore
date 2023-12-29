using Microsoft.AspNetCore.Mvc;

namespace ButtonListAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]/{content?}")]
    public class ButtonsController : Controller
    {
        private static readonly string[] buttons = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet(Name = "GetAllButtons")]
        public string[] Get()
        {
            return buttons;
        }

        [HttpPost(Name = "GetButtonContent")]
        public string GetContent(string content)
        {
            return content;
        }
    }
}
