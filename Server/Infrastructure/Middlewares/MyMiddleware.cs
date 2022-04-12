using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares
{
	public class MyMiddleware : object
	{
		//public MyMiddleware
		//	(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		//{
		//	_next = next;
		//}

		//private readonly Microsoft.AspNetCore.Http.RequestDelegate _next;

		public MyMiddleware
			(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		{
			Next = next;
		}

		private Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		public async System.Threading.Tasks.Task
			InvokeAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			// اول اجرا می‌شود

			// WriteAsync() -> using Microsoft.AspNetCore.Http;
			await httpContext.Response
				.WriteAsync(text: "<p>Hello World (1)!</p>");

			await Next(httpContext);

			// بعدی اجرا می‌شود Middleware بعد از اجرای شدن

			// WriteAsync() -> using Microsoft.AspNetCore.Http;
			await httpContext.Response
				.WriteAsync(text: "<p>Hello World (3)!</p>");
		}
	}
}
