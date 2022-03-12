// **************************************************
// **************************************************
// **************************************************
// Default
// **************************************************
using Microsoft.AspNetCore.Builder;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args);

var app =
	builder.Build();

// MapGet() -> using Microsoft.AspNetCore.Builder;
app.MapGet("/", () => "Hello World (1)!");

//app.MapGet("/", () =>
//{
//	return "Hello World (1)!";
//});

//app.MapPost("/", () => "Hello World (Post)!");
//app.MapPut("/", () => "Hello World (Put)!");
//app.MapDelete("/", () => "Hello World (Delete)!");

app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/
// https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api/
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 01
// **************************************************
// Build Custom Middleware - Inline Method
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (2)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 02
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (3)!");
//});

//// Note: Below code does not work!

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (4)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 03
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (5)!");

//	//await next();

//	// It is better!
//	await next.Invoke();
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (6)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 04
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (7)!");

//	// در نسخه‌های جدید کار نمی‌کند
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (8)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 05
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (9)!");

//	await next.Invoke();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (11)!");
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (10)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 06
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (12)!</p>");

//	await next();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (18)!</p>");
//});

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (13)!</p>");

//	await next();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (17)!</p>");
//});

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (14)!</p>");

//	await next();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (16)!</p>");
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (15)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 07
// **************************************************
// https://localhost:7271/		->	19
// https://localhost:7271/test1	->	20
// https://localhost:7271/test2	->	21
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/test1", Greeting1);

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/test2", Greeting2);

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (19)!</p>");
//});

//void Greeting1(IApplicationBuilder app)
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (20)!</p>");
//	});
//}

//// OR [static]

//static void Greeting2(IApplicationBuilder app)
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (21)!</p>");
//	});
//}

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 08
// **************************************************
// https://localhost:7271/		->	23
// https://localhost:7271/test	->	22
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/test", app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (22)!</p>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (23)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 09
// **************************************************
// https://localhost:7271/				->	26
// https://localhost:7271/test/test1	->	24
// https://localhost:7271/test/test2	->	25
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/test", app =>
//{
//	// Map() -> using Microsoft.AspNetCore.Builder;
//	app.Map("/test1", app =>
//	{
//		// Run() -> using Microsoft.AspNetCore.Builder;
//		app.Run(async context =>
//		{
//			// WriteAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response.WriteAsync("<p>Hello World (24)!</p>");
//		});
//	});

//	// Map() -> using Microsoft.AspNetCore.Builder;
//	app.Map("/test2", app =>
//	{
//		// Run() -> using Microsoft.AspNetCore.Builder;
//		app.Run(async context =>
//		{
//			// WriteAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response.WriteAsync("<p>Hello World (25)!</p>");
//		});
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (26)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 10
// **************************************************
// https://localhost:7271/				->	29
// https://localhost:7271/test/test1	->	27
// https://localhost:7271/test/test2	->	28
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/test/test1", app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (27)!</p>");
//	});
//});

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/test/test2", app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (28)!</p>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (29)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 11
// **************************************************
// https://localhost:7271/			->	32
// https://localhost:7271/?age=20	->	30
// https://localhost:7271/hitesthi	->	31
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// MapWhen() -> using Microsoft.AspNetCore.Builder;
//app.MapWhen(context => context.Request.Query.ContainsKey(key: "age"), app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (30)!</p>");
//	});
//});

//// MapWhen() -> using Microsoft.AspNetCore.Builder;
//app.MapWhen(context =>
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
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync("<p>Hello World (31)!</p>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<p>Hello World (32)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
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
//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
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

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
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

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("<h1>Error 404 - File Not Found!</h1>");
//});

//app.Run();
// **************************************************

// **************************************************
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
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//string contentRootPath =
//	app.Environment.ContentRootPath;

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/index.html", app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		//string physicalPathName =
//		//	$"{contentRootPath}\\wwwroot\\index.html";

//		string physicalPathName =
//			System.IO.Path.Combine(contentRootPath, "wwwroot", "index.html");

//		if (System.IO.File.Exists(physicalPathName))
//		{
//			// برنامه را یک بار بدون دو دستور ذیل اجرا می‌کنیم
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "text/html"; // Mime Type = Content Type = ذات فایل

//			// SendFileAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response.SendFileAsync(fileName: physicalPathName);
//		}
//	});
//});

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map("/images/Dariush.jpg", app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		string physicalPathName =
//			System.IO.Path.Combine(contentRootPath, "wwwroot\\images", "Dariush.jpg");

//		if (System.IO.File.Exists(physicalPathName))
//		{
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "image/jpeg";

//			// SendFileAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response.SendFileAsync(fileName: physicalPathName);
//		}
//	});
//});

//app.Run(async context =>
//{
//	await context.Response.WriteAsync("<h1>404 - File Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 16
// **************************************************
// ها بسیار اهمیت دارد Middleware تاکید مضاعف که ترتیب نوشتن
//
// https://localhost:7271/index.html
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World (33)!");
//});

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//app.Run();
// **************************************************
// **************************************************
// **************************************************










// **************************************************
// **************************************************
// **************************************************
// Learn 17
// **************************************************
//public void Configure
//	(Microsoft.AspNetCore.Builder.IApplicationBuilder app)
//{
//	app.UseMiddleware<Infrastructure.Middlewares.MyMiddleware1>();
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 18
// **************************************************
//public void Configure
//	(Microsoft.AspNetCore.Builder.IApplicationBuilder app)
//{
//	app.UseMiddleware<Infrastructure.Middlewares.MyMiddleware2>();

//	app.Run(async context =>
//	{
//		await context.Response.WriteAsync("Hello World (3)!");
//	});
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 19
// **************************************************
// In this lesson we use:
// Microsoft.AspNetCore.Hosting.IWebHostEnvironment env
// **************************************************
//public void Configure
//	(Microsoft.AspNetCore.Builder.IApplicationBuilder app,
//	Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
//{
//	// Custom UseStaticFiles
//	app.UseMiddleware<Infrastructure.Middlewares.MyMiddleware3>();

//	app.Run(async context =>
//	{
//		await context.Response.WriteAsync("Hello World!");
//	});
//}
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 20
// **************************************************
//public void Configure
//	(Microsoft.AspNetCore.Builder.IApplicationBuilder app)
//{
//	// Custom UseStaticFiles
//	app.UseMyMiddleware();
//}
// **************************************************
// **************************************************
// **************************************************
