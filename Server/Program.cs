// **************************************************
// **************************************************
// **************************************************
// Default
// **************************************************
using Microsoft.AspNetCore.Builder;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args: args);

var app =
	builder.Build();

// MapGet() -> using Microsoft.AspNetCore.Builder;
//app.MapGet("/", () => "Hello World!");

// MapGet() -> using Microsoft.AspNetCore.Builder;
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

// MapPost() -> using Microsoft.AspNetCore.Builder;
app.MapPost(pattern: "/", handler: () => "Hello World (Post)!");

// MapPut() -> using Microsoft.AspNetCore.Builder;
app.MapPut(pattern: "/", handler: () => "Hello World (Put)!");

// MapDelete() -> using Microsoft.AspNetCore.Builder;
app.MapDelete(pattern: "/", handler: () => "Hello World (Delete)!");

app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write/
//
// https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World!");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (1)!");
//});

//// Note: Below code does not work!

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (2)!");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (1)!");

//	//await next();

//	// It is better!
//	await next.Invoke();
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (2)!");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (1)!");

//	if (1 == 2)
//	{
//		await next.Invoke();
//	}

//	// در نسخه‌های جدید کار نمی‌کند
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (2)!");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (1)!");

//	await next.Invoke();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (3)!");
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World (2)!");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");

//	await next.Invoke();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (7)!</p>");
//});

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");

//	await next.Invoke();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (6)!</p>");
//});

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (3)!</p>");

//	await next.Invoke();

//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (5)!</p>");
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<p>Hello World (4)!</p>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test1", configuration: Greeting1);

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test2", configuration: Greeting2);

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//void Greeting1(IApplicationBuilder app)
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//}

//// OR [static]

//static void Greeting2(IApplicationBuilder app)
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test", configuration: app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response
//			.WriteAsync(text: "<p>Hello World!</p>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test", configuration: app =>
//{
//	// Map() -> using Microsoft.AspNetCore.Builder;
//	app.Map(pathMatch: "/test1", configuration: app =>
//	{
//		// Run() -> using Microsoft.AspNetCore.Builder;
//		app.Run(handler: async context =>
//		{
//			// WriteAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response
//				.WriteAsync(text: "<p>Hello World (1)!</p>");
//		});
//	});

//	// Map() -> using Microsoft.AspNetCore.Builder;
//	app.Map(pathMatch: "/test2", configuration: app =>
//	{
//		// Run() -> using Microsoft.AspNetCore.Builder;
//		app.Run(handler: async context =>
//		{
//			// WriteAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response
//				.WriteAsync(text: "<p>Hello World (2)!</p>");
//		});
//	});

//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response
//			.WriteAsync(text: "<h1>Error 404 - You can just use 'test1' or 'test2'!</h1>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test/test1", configuration: app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//});

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test/test2", configuration: app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// MapWhen() -> using Microsoft.AspNetCore.Builder;
//app.MapWhen(predicate: context => context.Request.Query.ContainsKey(key: "age"), app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//});

//// MapWhen() -> using Microsoft.AspNetCore.Builder;
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
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		// WriteAsync() -> using Microsoft.AspNetCore.Http;
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//});

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
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
//	.WebApplication.CreateBuilder(args: args);

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
//	.WebApplication.CreateBuilder(args: args);

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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//string contentRootPath =
//	app.Environment.ContentRootPath;

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/index.html", configuration: app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(async context =>
//	{
//		//string physicalPathName =
//		//	$"C:\\inetpub\\Users\\IranianExperets\\wwwroot\\index.html";

//		//string physicalPathName =
//		//	"{contentRootPath}" + "wwwroot\\index.html";

//		//string physicalPathName =
//		//	$"{contentRootPath}wwwroot\\index.html";

//		string physicalPathName =
//			System.IO.Path.Combine(contentRootPath, "wwwroot", "index.html");

//		if (System.IO.File.Exists(physicalPathName))
//		{
//			// برنامه را یک بار بدون دو دستور ذیل اجرا می‌کنیم
//			//context.Response.StatusCode = 200;

//			context.Response.ContentType =
//				"text/html"; // Mime Type = Content Type = ذات یا ماهیت فایل

//			//context.Response.ContentType =
//			//	"alaki/dolaki"; // Mime Type = Content Type = ذات یا ماهیت فایل

//			// SendFileAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response
//				.SendFileAsync(fileName: physicalPathName);
//		}
//	});
//});

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/images/Dariush.jpg", configuration: app =>
//{
//	// Run() -> using Microsoft.AspNetCore.Builder;
//	app.Run(handler: async context =>
//	{
//		string physicalPathName =
//			System.IO.Path.Combine(contentRootPath, "wwwroot\\images", "Dariush.jpg");

//		if (System.IO.File.Exists(physicalPathName))
//		{
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "image/jpeg";

//			// SendFileAsync() -> using Microsoft.AspNetCore.Http;
//			await context.Response
//				.SendFileAsync(fileName: physicalPathName);
//		}
//	});
//});

//app.Run(async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
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
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "Hello World!");
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
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// UseMiddleware() -> using Microsoft.AspNetCore.Builder;
//app.UseMiddleware<Infrastructure.Middlewares.MyMiddleware>();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync()-> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 18
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// UseMiddleware() -> using Microsoft.AspNetCore.Builder;
//app.UseMiddleware<Infrastructure
//	.Middlewares.CustomStaticFilesHandlerMiddleware>();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 19
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// UseCustomStaticFiles() -> using Infrastructure.Middlewares;
//app.UseCustomStaticFiles();

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 20
// **************************************************
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// UseCustomStaticFiles() -> using Infrastructure.Middlewares;
//app.UseGlobalException();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************
