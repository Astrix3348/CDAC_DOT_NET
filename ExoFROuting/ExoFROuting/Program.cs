namespace ExoFROuting;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => "hello from myside");


        //creating the endpoints
        //app.MapGet("map1", async (context) =>
        //{
        //    await context.Response.WriteAsync("In Map 1");
        //});


        //app.MapGet("map2", async (context) =>
        //{
        //    await context.Response.WriteAsync("In Map 2");
        //});

        //now example of RouteParameters
        //app.Map("files/{filename}.{extension}", async (context) =>
        //{
        //    string filename = Convert.ToString(context.Request.RouteValues["filename"]);
        //    string extension = Convert.ToString(context.Request.RouteValues["extension"]);

        //    await context.Response.WriteAsync($"in the file {filename} - {extension}");
        //});



        //also an example for route parameters
        //app.Map("products/{id?}", async (cont) =>
        //{
        //    if (cont.Request.RouteValues.ContainsKey("id"))
        //    {
        //        int id = Convert.ToInt32(cont.Request.RouteValues["id"]);
        //        await cont.Response.WriteAsync($"the id is - {id}");
        //    }
        //    else
        //    {
        //        cont.Response.WriteAsync("id is not supplied!");
        //    }
        //});



        //example of a route constraint

        app.Map("books/{id:int?}", async (context) =>
        {
            if (context.Request.RouteValues.ContainsKey("id")){
                int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                await context.Response.WriteAsync($"the id is {id}");
            }
            else
            {
                await context.Response.WriteAsync("something is wrong");
            }
        });

        app.MapFallback(async (context) =>
        {
            await context.Response.WriteAsync($"request received at {context.Request.Path}");
        });


        app.Run();
    }
}

