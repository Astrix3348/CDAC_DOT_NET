namespace ExOfUseWhen;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        app.UseWhen(context => context.Request.Query.ContainsKey("username"),
            app =>
            {
                app.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("hello from the UseWHen exmaple!");
                    await next();
                });
            });
        

        app.Run();
    }
}

