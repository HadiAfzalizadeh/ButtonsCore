using ButtonListAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ButtonListAPI.Controllers
{
    [ApiController]
    [Route("api/Buttons")]
    public class ButtonsController : ControllerBase
    {
        private readonly IRepository _buttonsRepository;
        public ButtonsController(IRepository buttonsRepository) {
            this._buttonsRepository = buttonsRepository;
        }

        [HttpGet]
        public ActionResult<string[]> Get()
        {
            return Ok(this._buttonsRepository.GetAllButtons());
        }

        [HttpPost("GetContent/{content}")]
        public async Task<ActionResult<string>> GetContent(string content)
        {
            await Task.Delay(1500);
            return Ok(content);
        }
    }
}
