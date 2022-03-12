using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares
{
	public class MyMiddleware2 : object
	{
		public MyMiddleware2
			(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		{
			Next = next;
		}

		protected Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		public async System.Threading.Tasks.Task Invoke
			(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			// WriteAsync -> Extension Method -> using Microsoft.AspNetCore.Http;
			await httpContext.Response.WriteAsync("Hello World (1)!");

			await Next(httpContext);

			await httpContext.Response.WriteAsync("Hello World (2)!");
		}
	}
}
