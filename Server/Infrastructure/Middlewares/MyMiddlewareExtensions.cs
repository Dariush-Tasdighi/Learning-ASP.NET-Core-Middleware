using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Middlewares
{
	public static class MyMiddlewareExtensions
	{
		static MyMiddlewareExtensions()
		{
		}

		public static Microsoft.AspNetCore.Builder.IApplicationBuilder
			UseMyMiddleware(this Microsoft.AspNetCore.Builder.IApplicationBuilder builder)
		{
			return builder.UseMiddleware<MyMiddleware3>();
		}
	}
}
