using MiddlewaresExample.CustomMiddleware;
namespace MiddlewaresExample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
       // builder.Services.AddTransient<AnotherMiddleware>(); // we are adding the middleware services here
        var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        //app.Run();

        //this is the example of the middleware

        //this is the custom middleware
        //app.UseMyCustomMiddleware();

        //app.Run(async (HttpContext context) =>
        //{
        //    await context.Response.WriteAsync("hello");
        //});



        //now this is an example of middleware chaining
        //middleware 1
        //app.Use(async (HttpContext context, RequestDelegate next) =>
        //{
        //    await context.Response.WriteAsync("Hello\n");
        //    await next(context);
        //});

        ////middleware 2
        //app.Use(async (HttpContext context, RequestDelegate next) =>
        //{
        //    await context.Response.WriteAsync("hello end\n");
        //    await next(context);
        //});

        ////this is the terminal
        //app.Run(async (HttpContext context) =>
        //{
        //    context.Response.WriteAsync("Ending the middleware");
        //});


        //middleware 1
        app.Use(async (HttpContext context, RequestDelegate next) =>
        {
            await context.Response.WriteAsync("From middleware\n");
            await next(context);
        });

        app.UseAnotherMiddleware();


        app.Run(async (HttpContext context) =>
        {
            await context.Response.WriteAsync("This is after the Another Middleware");
        });

        app.Run();

    }
}

