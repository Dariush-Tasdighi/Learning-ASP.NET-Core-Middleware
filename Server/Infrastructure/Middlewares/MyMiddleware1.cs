//namespace MY_APPLICATION.Infrastructure.Middlewares
namespace Infrastructure.Middlewares
{
	public class MyMiddleware1 : object
	{
		//public MyMiddleware1(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		//{
		//	_next = next;
		//}

		//private readonly Microsoft.AspNetCore.Http.RequestDelegate _next;

		public MyMiddleware1
			(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
		{
			Next = next;
		}

		protected Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		public
			async
			System.Threading.Tasks.Task
			Invoke(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			// اول اجرا می‌شود

			await Next(httpContext);

			// بعد از اجرا شدن میدلویر بعدی اجرا می‌شود
		}
	}
}
