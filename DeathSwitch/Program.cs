namespace DeathSwitch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World! Ofentse Ismael Luyanda");
            app.MapGet("/", () => "Hello World! i love my group ");
            app.MapGet("/", () => "10k");
            app.MapGet("/", () => "Hello World! i love my group ");
            app.MapGet("/", () => "they want this  ");
            app.MapGet("/", () => "Hello World! i love my group ");
            app.MapGet("/", () => "they want this ");
            app.Run();
        }
    }
}
