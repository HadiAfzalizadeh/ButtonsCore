using Microsoft.AspNetCore.Mvc;

namespace ButtonListAPI.Controllers
{
    [ApiController]
    [Route("api/Buttons")]
    public class ButtonsController : Controller
    {
        private static readonly string[] buttons = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public string[] Get()
        {
            return buttons;
        }

        [HttpPost("GetContent/{content}")]
        public string GetContent(string content)
        {
            return content;
        }
    }
}
