namespace Assignment_1._1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        //app.Use(async (HttpContext context, RequestDelegate next) =>
        //{
        //    string fulluser =  context.Request.Query["username"] + " " + context.Request.Query["password"];
        //    await context.Response.WriteAsync(fulluser);
        //    await next(context);
        //});

        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("this is the first middleware!");
            await next(context);
        });

        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("this is the start of the second middleware");
            await next(context);
        });

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("this is the end for the second middleware");
        });



        app.Run();
    }
}

