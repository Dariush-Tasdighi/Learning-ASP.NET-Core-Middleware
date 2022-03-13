﻿using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares
{
	public class GlobalExceptionHandlerMiddleware : object
	{
		public GlobalExceptionHandlerMiddleware
			(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		{
			Next = next;
		}

		private Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		public async System.Threading.Tasks.Task
			InvokeAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			try
			{
				await Next(httpContext);
			}
			catch (System.Exception ex)
			{
				// Log Error!

				httpContext.Response.Redirect
					(location: "/Errors/Error500", permanent: false);

				// دستور ذیل غلط است
				//httpContext.Response.Redirect
				//	(location: "~/Errors/Error500", permanent: false);
			}
		}
	}
}
