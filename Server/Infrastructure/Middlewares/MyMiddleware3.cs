using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares
{
	public class MyMiddleware3 : object
	{
		//public MyMiddleware3
		//	(Microsoft.AspNetCore.Http.RequestDelegate next,
		//	Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment)
		//{
		//	_next = next;
		//	_hostEnvironment = hostEnvironment;
		//}

		//private readonly Microsoft.AspNetCore.Http.RequestDelegate _next;
		//private readonly Microsoft.Extensions.Hosting.IHostEnvironment _hostEnvironment;

		public MyMiddleware3
			(Microsoft.AspNetCore.Http.RequestDelegate next,
			Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment)
		{
			Next = next;
			HostEnvironment = hostEnvironment;
		}

		protected Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

		protected Microsoft.Extensions.Hosting.IHostEnvironment HostEnvironment { get; }

		public async System.Threading.Tasks.Task Invoke
			(Microsoft.AspNetCore.Http.HttpContext httpContext)
		{
			string path =
				httpContext.Request.Path;

			if (string.IsNullOrWhiteSpace(path) || path == "/")
			{
				await Next(httpContext);

				// در این حالت دستور ذیل خیلی مهم است
				return;
			}

			if (path.StartsWith("/") == false)
			{
				await Next(httpContext);

				return;
			}

			// Path: /index.html -> Path: index.html
			path =
				path.Substring(startIndex: 1);

			string contentRootPath =
				HostEnvironment.ContentRootPath;

			string physicalPathName =
				System.IO.Path.Combine(contentRootPath, "wwwroot", path);

			// برای بالا بردن امنیت
			//string physicalPathName =
			//	System.IO.Path.Combine(contentRootPath, "wwwroot/content", path);

			if (System.IO.File.Exists(physicalPathName) == false)
			{
				await Next(httpContext);

				return;
			}

			// Reference:
			// https://stackoverflow.com/questions/4576483/how-to-get-the-content-type-of-a-file-at-runtime

			// **************************************************
			string fileExtension =
				System.IO.Path.GetExtension(physicalPathName).ToLower();

			switch (fileExtension)
			{
				case ".htm":
				case ".html":
				{
					httpContext.Response.StatusCode = 200;
					httpContext.Response.ContentType = "text/html";
					break;
				}

				case ".css":
				{
					httpContext.Response.StatusCode = 200;
					httpContext.Response.ContentType = "text/css";
					break;
				}

				case ".js":
				{
					httpContext.Response.StatusCode = 200;
					httpContext.Response.ContentType = "application/x-javascript";
					break;
				}

				case ".jpg":
				case ".jpeg":
				{
					httpContext.Response.StatusCode = 200;
					httpContext.Response.ContentType = "image/jpeg";
					break;
				}

				case ".txt":
				{
					httpContext.Response.StatusCode = 200;
					httpContext.Response.ContentType = "text/plain";
					break;
				}

				default:
				{
					await Next(httpContext);

					return;
				}
			}
			// **************************************************

			// نکته مهم: آدرس فایل باید فیزیکی باشد
			// C:/inetput/wwwroot/IranianExperts/SomeFile.css
			// D:/wwwroot/IranianExperts/SomeFile.css
			// ASP.NET WebForm & ASP.NET MVC (Classic) -> Server.MapPath("~/SomeFile.css") -> Physical Address
			await httpContext.Response.SendFileAsync(fileName: physicalPathName);
		}
	}
}
