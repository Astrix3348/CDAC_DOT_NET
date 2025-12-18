namespace MiddlewaresExample.CustomMiddleware
{
	public class AnotherMiddleware
	{
		private readonly RequestDelegate _next;

		public AnotherMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{

			

            if (context.Request.Query.ContainsKey("FirstName") &&
				context.Request.Query.ContainsKey("LastName"))
			{
                    string fullname = context.Request.Query["FirstName"] + " " +
					context.Request.Query["LastName"];

                await context.Response.WriteAsync(fullname + "\n");

            }
			
			await _next(context);
			
			
		}
	}

	//this is an extension method used to add middleware to http request pipeline
	public static class AnotherMiddleExtension
	{
		public static IApplicationBuilder UseAnotherMiddleware(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<AnotherMiddleware>();
		}
	}
}

