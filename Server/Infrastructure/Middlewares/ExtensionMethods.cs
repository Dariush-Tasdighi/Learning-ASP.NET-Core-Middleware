using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Middlewares;

public static class ExtensionMethods
{
	static ExtensionMethods()
	{
	}

	public static IApplicationBuilder
		UseCustomStaticFiles(this IApplicationBuilder app)
	{
		return app.UseMiddleware<CustomStaticFilesHandlerMiddleware>();
	}

	public static IApplicationBuilder
		UseGlobalException(this IApplicationBuilder app)
	{
		return app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
	}

	//public static IApplicationBuilder
	//	UseSomething(this IApplicationBuilder app, int x, int y)
	//{
	//	return app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
	//}
}
