
namespace MiddlewaresExample.CustomMiddleware
{
	public class MyCustom : IMiddleware
	{
		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			await context.Response.WriteAsync("this is my custom middleware start\n");
			await next(context);
			await context.Response.WriteAsync("this is my custom end\n");
		}
	}

	public static class CustomMiddlewareExtension
	{
		public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
		{
			return app.UseMiddleware<MyCustom>();
		}
	}
}

