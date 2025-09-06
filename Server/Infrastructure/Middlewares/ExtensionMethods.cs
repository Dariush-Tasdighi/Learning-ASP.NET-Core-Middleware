using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Middlewares;

public static class ExtensionMethods : object
{
	public static string? Fix(this string? text)
	{
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return null;
		}

		text = text.Trim();

		if (text == string.Empty)
		{
			return null;
		}

		while (text.Contains(value: "  "))
		{
			text = text.Replace(oldValue: "  ", newValue: " ");
		}

		return text;
	}

	public static IApplicationBuilder UseCustomStaticFiles(this IApplicationBuilder app)
	{
		return app.UseMiddleware<CustomStaticFilesHandlerMiddleware>();
	}

	public static IApplicationBuilder UseCustomGlobalException(this IApplicationBuilder app)
	{
		return app.UseMiddleware<CustomGlobalExceptionHandlerMiddleware>();
	}
}
