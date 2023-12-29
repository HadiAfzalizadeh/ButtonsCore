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
        public async Task<string> GetContent(string content)
        {
            await Task.Delay(1500);
            return content;
        }
    }
}
