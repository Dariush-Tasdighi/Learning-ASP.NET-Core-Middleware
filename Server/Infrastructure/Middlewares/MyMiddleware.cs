using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares;

public class MyMiddleware : object
{
	//public MyMiddleware(RequestDelegate next) : base()
	//{
	//	_next = next;
	//}

	//private readonly RequestDelegate _next;

	public MyMiddleware(RequestDelegate next) : base()
	{
		Next = next;
	}

	/// <summary>
	/// Best Practice!
	/// </summary>
	private RequestDelegate Next { get; }

	public async Task InvokeAsync(HttpContext httpContext)
	{
		// ابتدا، دستور ذیل اجرا می‌شود

		await httpContext.Response
			.WriteAsync(text: "<p>Hello World (1)!</p>");

		await Next(context: httpContext);

		// بعدی، اجرا می‌شود Middleware دستور ذیل، بعد از اجرای شدن

		await httpContext.Response
			.WriteAsync(text: "<p>Hello World (3)!</p>");
	}
}
