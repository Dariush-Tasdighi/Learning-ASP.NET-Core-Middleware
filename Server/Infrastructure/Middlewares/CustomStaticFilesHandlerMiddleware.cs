using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Infrastructure.Middlewares;

// **************************************************
// **************************************************
// **************************************************
public class CustomStaticFilesHandlerMiddleware : object
{
	public CustomStaticFilesHandlerMiddleware
		(RequestDelegate next, IHostEnvironment hostEnvironment) : base()
	{
		Next = next;
		HostEnvironment = hostEnvironment;
	}

	private RequestDelegate Next { get; }

	private IHostEnvironment HostEnvironment { get; }

	public async Task InvokeAsync(HttpContext httpContext)
	{
		// نکته مهم
		// استفاده می‌کنیم، دستورات ذیل، دوبار اجرا می‌شوند؟ Breakpoint چرا وقتی از

		var requestPathValue =
			httpContext.Request.Path.Value;

		if (string.IsNullOrWhiteSpace(value: requestPathValue) || requestPathValue == "/")
		{
			await Next(context: httpContext);

			// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
			return;
		}

		if (requestPathValue.StartsWith(value: "/") == false)
		{
			await Next(context: httpContext);

			// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
			return;
		}

		// **************************************************
		// requestPath: /index.html -> requestPath: index.html
		//requestPath =
		//	requestPath.Substring(startIndex: 1);

		requestPathValue =
			requestPathValue[1..];
		// **************************************************

		// **************************************************
		// آدرس فیزیکی ریشه سایت را بدست می‌آوریم
		var rootPath =
			HostEnvironment.ContentRootPath;

		// In ASP.NET WebForm and ASP.NET MVC (Classic) -> Server.MapPath("~/SomeFile.css") -> Physical Address
		// **************************************************

		// **************************************************
		var physicalPathName =
			Path.Combine(path1: rootPath, path2: "wwwroot", path3: requestPathValue);

		// برای بالا بردن امنیت
		//var physicalPathName =
		//	Path.Combine(contentRootPath, "wwwroot\\content", path);
		// **************************************************

		if (File.Exists(path: physicalPathName) == false)
		{
			await Next(context: httpContext);

			// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
			return;
		}

		// **************************************************
		// Reference:
		// https://stackoverflow.com/questions/4576483/how-to-get-the-content-type-of-a-file-at-runtime
		// **************************************************

		// **************************************************
		// می‌باشد string? باید دقت داشته باشیم که خروجی تابع ذیل از جنس
		var fileExtension =
			Path.GetExtension(path: physicalPathName)?.ToLower();

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
				await Next(context: httpContext);

				// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
				return;
			}
		}
		// **************************************************

		// نکته مهم: آدرس فایل باید فیزیکی باشد
		await httpContext.Response
			.SendFileAsync(fileName: physicalPathName);
	}
}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
//public class CustomStaticFilesHandlerMiddleware : object
//{
//	public CustomStaticFilesHandlerMiddleware(RequestDelegate next) : base()
//	{
//		Next = next;
//	}

//	private RequestDelegate Next { get; }

//	public async Task InvokeAsync
//		(HttpContext httpContext, IHostEnvironment hostEnvironment)
//	{
//		var requestPath =
//			httpContext.Request.Path.Value;

//		if (string.IsNullOrWhiteSpace(value: requestPath) || requestPath == "/")
//		{
//			await Next(context: httpContext);
//			return;
//		}

//		if (requestPath.StartsWith(value: "/") == false)
//		{
//			await Next(context: httpContext);
//			return;
//		}

//		requestPath =
//			requestPath[1..];

//		var rootPath =
//			hostEnvironment.ContentRootPath;

//		var physicalPathName =
//			Path.Combine(path1: rootPath, path2: "wwwroot", path3: requestPath);

//		if (File.Exists(path: physicalPathName) == false)
//		{
//			await Next(context: httpContext);
//			return;
//		}

//		var fileExtension =
//			Path.GetExtension(path: physicalPathName)?.ToLower();

//		switch (fileExtension)
//		{
//			case ".htm":
//			case ".html":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "text/html";
//				break;
//			}

//			case ".css":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "text/css";
//				break;
//			}

//			case ".js":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "application/x-javascript";
//				break;
//			}

//			case ".jpg":
//			case ".jpeg":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "image/jpeg";
//				break;
//			}

//			case ".txt":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "text/plain";
//				break;
//			}

//			default:
//			{
//				await Next(context: httpContext);
//				return;
//			}
//		}

//		await httpContext.Response
//			.SendFileAsync(fileName: physicalPathName);
//	}
//}
// **************************************************
// **************************************************
// **************************************************
