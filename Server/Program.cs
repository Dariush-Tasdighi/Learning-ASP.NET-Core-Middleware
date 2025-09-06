
// **************************************************
// Default
// **************************************************
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args: args);

var app = builder.Build();

// Get One or More
//app.MapGet("/", () => "Hello World!");

app.MapGet(pattern: "/", handler: () => "Hello World!");

//app.MapGet(pattern: "/", handler: () =>
//{
//	var result = "Hello";

//	if (1 == 1)
//	{
//		result += " World!";
//	}

//	return result;
//});

// Application: Postman

// Create
app.MapPost(pattern: "/", handler: () => "Hello World (Post)!");

// Edit
app.MapPut(pattern: "/", handler: () => "Hello World (Put)!");

// Delete
app.MapDelete(pattern: "/", handler: () => "Hello World (Delete)!");

app.Run();
// **************************************************


// **************************************************
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write/
//
// https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/
// **************************************************


// **************************************************
// Learn 01
// **************************************************
// Build Custom Middleware - Inline Method
//
// https://localhost:7271
// https://localhost:7271/
// https://localhost:7271/alaki/
// https://localhost:7271/alaki/dolaki
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 02
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//});

//// Note: Below code does not work!

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 03
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");

//	//await next();

//	// Best Practice!
//	await next.Invoke();
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 04
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");

//	var x = 1;
//	var y = 2;

//	if (x == y)
//	{
//		await next.Invoke();
//	}
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 05
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (3)!</p>");
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 06
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (7)!</p>");
//});

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (6)!</p>");
//});

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (3)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (5)!</p>");
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (4)!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 07
// **************************************************
// https://localhost:7271
// https://localhost:7271/
// https://localhost:7271/alaki
// https://localhost:7271/test1
// https://localhost:7271/test2
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

////app.Map(pathMatch: "/", configuration: SomeFunction);

//app.Map(pathMatch: "/test1", configuration: Greeting1);

//app.Map(pathMatch: "/test2", configuration: Greeting2);

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

////string SomeFunction(int alaki, string dolaki)
////{
////	return "Hello, World!";
////}

//void Greeting1(IApplicationBuilder app)
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//}

//// OR [static]
//// هر دو حالت کار می‌کند

//static void Greeting2(IApplicationBuilder app)
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//}

//app.Run();
// **************************************************


// **************************************************
// Learn 08
// **************************************************
// https://localhost:7271/
// https://localhost:7271/test
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Map(pathMatch: "/test", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World!</p>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 09
// **************************************************
// Nested Routing
//
// https://localhost:7271/
// https://localhost:7271/googooli
// https://localhost:7271/test/
// https://localhost:7271/test/test1
// https://localhost:7271/test/test2
// https://localhost:7271/test/googooli
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Map(pathMatch: "/test", configuration: app =>
//{
//	app.Map(pathMatch: "/test1", configuration: app =>
//	{
//		app.Run(handler: async context =>
//		{
//			await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//		});
//	});

//	app.Map(pathMatch: "/test2", configuration: app =>
//	{
//		app.Run(handler: async context =>
//		{
//			await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//		});
//	});

//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync
//			(text: "<h1>Error 404 - You must also write 'test1' or 'test2'!</h1>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 10
// **************************************************
// https://localhost:7271/
// https://localhost:7271/googooli
// https://localhost:7271/test/
// https://localhost:7271/test/test1
// https://localhost:7271/test/test2
// https://localhost:7271/test/googooli
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Map(pathMatch: "/test/test1", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//});

//app.Map(pathMatch: "/test/test2", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//});

//app.Map(pathMatch: "/test", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync
//			(text: "<h1>Error 404 - You must also write 'test1' or 'test2'!</h1>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 11
// **************************************************
// https://localhost:7271/
// https://localhost:7271/?age=20
// https://localhost:7271/hitesthi
// https://localhost:7271/alaki?age=20
// https://localhost:7271/alaki/hitesthi
// https://localhost:7271/alaki/hitesthi?age=20
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.MapWhen(predicate: context => context.Request.Query.ContainsKey(key: "age"), app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//});

//app.MapWhen(predicate: context =>
//{
//	if (context.Request.Path != null &&
//		context.Request.Path.Value != null &&
//		context.Request.Path.Value.Contains(value: "test"))
//	{
//		return true;
//	}
//	else
//	{
//		return false;
//	}
//},
//app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 12
// **************************************************
// 1. Create [wwwroot] folder.
// 2. Create [Index.html] file in it.
// 3. Test below url in browser:
// https://localhost:7271/index.html
//
// Note: We can not see the index.html page!
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Run();
// **************************************************


// **************************************************
// Learn 13
// **************************************************
// 1. Create [wwwroot] folder.
// 2. Create [Index.html] file in it.
// 3. Test below url in browser:
//
// https://localhost:7271/index.html
//
// Note: Now, We can see the index.html page!
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.UseStaticFiles();

//app.Run();
// **************************************************


// **************************************************
// Learn 14
// **************************************************
// 1. Create [wwwroot] folder.
// 2. Create [Index.html] file in it.
// 3. Test below url in browser:
//
// https://localhost:7271/
// https://localhost:7271/index.html
// https://localhost:7271/images/Dariush.jpg
// https://localhost:7271/alaki.html
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.UseStaticFiles();

//app.Run(handler: async context =>
//{
//	var text = "<h1>Error 404 - Content Not Found!</h1>";
//	await context.Response.WriteAsync(text: text);
//});

//app.Run();
// **************************************************

// **************************************************
// Learn 15
// **************************************************
// استفاده نمی‌کردیم UseStaticFiles اگر از
//
// https://localhost:7271/
// https://localhost:7271/index.html
// https://localhost:7271/images/Dariush.jpg
// **************************************************
//using System.IO;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//// wwwroot مسیر فیزیکی
//var contentRootPath = app.Environment.ContentRootPath;

//app.Map(pathMatch: "/index.html", configuration: app =>
//{
//	app.Run(async context =>
//	{
//		// فاجعه - حماقت
//		//var physicalPathName =
//		//	$"c:\\inetpub\\wwwusers\\DariushTasdighi\\wwwroot\\index.html";

//		//var physicalPathName = contentRootPath + "wwwroot\\index.html";

//		//var physicalPathName = $"{contentRootPath}wwwroot\\index.html";

//		var physicalPathName = Path.Combine
//			(path1: contentRootPath, path2: "wwwroot", path3: "index.html");

//		if (File.Exists(path: physicalPathName))
//		{
//			// مقدار ذیل، به طور پیش‌فرض، همیشه ۲۰۰ می‌باشد
//			context.Response.StatusCode = 200;

//			// برنامه را در دو حالت ذیل اجرا می‌کنیم

//			// Mime Type = Content Type = ذات یا ماهیت فایل
//			context.Response.ContentType = "text/html";
//			//context.Response.ContentType = "alaki/dolaki";

//			// اگر فایل به صورت فیزیکی وجود نداشته باشد، دستور ذیل خطا می‌دهد
//			await context.Response.SendFileAsync(fileName: physicalPathName);
//		}
//		else
//		{
//			var text = "<h1>Error 404 - Content Not Found!</h1>";
//			await context.Response.WriteAsync(text: text);
//		}
//	});
//});

//app.Map(pathMatch: "/images/Dariush.jpg", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		var physicalPathName = Path.Combine
//			(path1: contentRootPath, path2: "wwwroot", path3: "images", path4: "Dariush.jpg");

//		if (File.Exists(path: physicalPathName))
//		{
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "image/jpeg";

//			await context.Response.SendFileAsync(fileName: physicalPathName);
//		}
//		else
//		{
//			var text = "<h1>Error 404 - Content Not Found!</h1>";
//			await context.Response.WriteAsync(text: text);
//		}
//	});
//});

//app.Run(async context =>
//{
//	var text = "<h1>Error 404 - Content Not Found!</h1>";
//	await context.Response.WriteAsync(text: text);
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 16
// **************************************************
// ها بسیار اهمیت دارد Middleware تاکید مضاعف: ترتیب نوشتن
//
// https://localhost:7271/index.html
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World!");
//});

//app.UseStaticFiles();

//app.Run();
// **************************************************


// **************************************************
// Learn 17
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.UseMiddleware<MyMiddleware>();

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 18
// **************************************************
// https://localhost:7271/index.html
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.UseMiddleware<CustomStaticFilesHandlerMiddleware>();

//app.Run(handler: async context =>
//{
//	var text = "<h1>Error 404 - Content Not Found!</h1>";
//	await context.Response.WriteAsync(text: text);
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 19
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.UseCustomStaticFiles();

//app.Run(async context =>
//{
//	var text = "<h1>Error 404 - Content Not Found!</h1>";
//	await context.Response.WriteAsync(text: text);
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 20
// **************************************************
// https://localhost:7271/index
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//// New
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// New
//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 21
// **************************************************
// https://localhost:7271/index
// **************************************************
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//// باید اول نوشته شود MiddleWare این
//app.UseCustomGlobalException();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 22
// **************************************************
// https://localhost:7271/index
// **************************************************
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.UseCustomGlobalException();
//app.UseCustomStaticFiles();
//app.MapRazorPages();

//app.Run();
// **************************************************
