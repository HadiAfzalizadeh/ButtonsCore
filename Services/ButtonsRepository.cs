namespace ButtonListAPI.Services
{
    public class ButtonsRepository : IRepository
    {
        private static readonly string[] _buttons = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public string[] GetAllButtons()
        {
            return _buttons;       
        }

    }
}
