using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Middlewares
{
	public static class ExtensionMethods
	{
		static ExtensionMethods()
		{
		}

		public static Microsoft.AspNetCore.Builder.IApplicationBuilder
			UseCustomStaticFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app)
		{
			// UseMiddleware -> //using Microsoft.AspNetCore.Builder;
			return app.UseMiddleware<CustomStaticFilesHandlerMiddleware>();
		}

		public static Microsoft.AspNetCore.Builder.IApplicationBuilder
			UseGlobalException(this Microsoft.AspNetCore.Builder.IApplicationBuilder app)
		{
			// UseMiddleware -> //using Microsoft.AspNetCore.Builder;
			return app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
		}

		//public static Microsoft.AspNetCore.Builder.IApplicationBuilder
		//	UseSomething(this Microsoft.AspNetCore.Builder.IApplicationBuilder app, int x, int y)
		//{
		//	// UseMiddleware -> //using Microsoft.AspNetCore.Builder;
		//	return app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
		//}
	}
}
