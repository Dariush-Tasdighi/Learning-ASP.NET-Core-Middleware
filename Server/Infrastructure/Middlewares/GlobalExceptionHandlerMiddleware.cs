using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares;

public class GlobalExceptionHandlerMiddleware : object
{
	public GlobalExceptionHandlerMiddleware(RequestDelegate next) : base()
	{
		Next = next;
	}

	private RequestDelegate Next { get; }

	public async Task InvokeAsync(HttpContext httpContext)
	{
		try
		{
			await Next(context: httpContext);
		}
		catch //(System.Exception ex)
		{
			// Log Error (ex)!

			httpContext.Response.Redirect
				(location: "/Errors/Error500", permanent: false);

			// (~/): دستور ذیل غلط است و کار نمی‌کند
			//httpContext.Response.Redirect
			//	(location: "~/Errors/Error500", permanent: false);
		}
	}
}
