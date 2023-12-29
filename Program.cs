namespace ButtonListAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            var app = builder.Build();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Buttons}/{action=SampleId}/{id?}");

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.Run();
        }
    }
}