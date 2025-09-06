using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares;

public class CustomGlobalExceptionHandlerMiddleware : object
{
	public CustomGlobalExceptionHandlerMiddleware(RequestDelegate next) : base()
	{
		Next = next;
	}

	private RequestDelegate Next { get; init; }

	public async Task InvokeAsync(HttpContext httpContext)
	{
		try
		{
			await Next(context: httpContext);
		}
		catch // (Exception ex)
		{
			// Note: Log Error (ex)!

			httpContext.Response.Redirect
				(location: "/Errors/Error500", permanent: false);

			// Note: (~/): دستور ذیل غلط است و کار نمی‌کند
			//httpContext.Response.Redirect
			//	(location: "~/Errors/Error500", permanent: false);
		}
	}
}
