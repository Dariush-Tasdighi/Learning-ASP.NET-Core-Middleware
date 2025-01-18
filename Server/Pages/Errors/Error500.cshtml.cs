using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages.Errors;

public class Error500Model : PageModel
{
	public Error500Model() : base()
	{
	}

	public void OnGet()
	{
		HttpContext.Response.StatusCode = 500;
	}
}
