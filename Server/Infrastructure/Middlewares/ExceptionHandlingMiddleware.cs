using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares
{
	public class ExceptionHandlingMiddleware : object
	{
		public ExceptionHandlingMiddleware
			(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		{
			Next = next;
		}

		protected Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		public async System.Threading.Tasks.Task InvokeAsync
			(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			try
			{
				await Next(httpContext);
			}
			catch (System.Exception ex)
			{
				await HandleException(httpContext.Response, ex);
			}
		}

		private static async System.Threading.Tasks.Task HandleException
			(Microsoft.AspNetCore.Http.HttpResponse httpResponse, System.Exception exception)
		{
			// Log

			httpResponse.Headers.Add("Exception-Type", exception.GetType().Name);

			var feature =
				httpResponse.HttpContext.Features
				.Get<Microsoft.AspNetCore.Http.Features.IHttpResponseFeature>();

			feature.ReasonPhrase =
				"خطای ناشناخته‌ای صورت گرفته است! یا مجددا سعی نمایید و یا با تیم پشتیبانی تماس حاصل فرمایید.";

			httpResponse.StatusCode =
				(int)System.Net.HttpStatusCode.BadRequest;

			await httpResponse.WriteAsync(exception.Message).ConfigureAwait(false);
		}
	}
}
