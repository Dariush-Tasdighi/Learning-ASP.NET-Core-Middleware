using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Middlewares;

public static class ExtensionMethods : object
{
	public static IApplicationBuilder
		UseCustomStaticFiles(this IApplicationBuilder app)
	{
		return app.UseMiddleware<CustomStaticFilesHandlerMiddleware>();
	}

	public static IApplicationBuilder
		UseCustomGlobalException(this IApplicationBuilder app)
	{
		return app.UseMiddleware<CustomGlobalExceptionHandlerMiddleware>();
	}

	//public static IApplicationBuilder
	//	UseSomething(this IApplicationBuilder app, int x, int y)
	//{
	//	return app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
	//}
}
