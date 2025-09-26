class Program
{
    private static async Task HelloWorldDelegate(HttpContext context)
    {
        await context.Response.WriteAsync("Hello World!");
        Console.WriteLine("Hello called");
    }

    private static async Task GoodbyeWorldDelegate(HttpContext context)
    {
        await context.Response.WriteAsync("Goodbye World!");
        Console.WriteLine("Goodbye called");
    }

    static void Main(String[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        WebApplication app = builder.Build();

        app.MapGet("/", HelloWorldDelegate);
        app.MapGet("/hello", HelloWorldDelegate);
        app.MapGet("/goodbye", GoodbyeWorldDelegate);

        app.Run();
    }
}
