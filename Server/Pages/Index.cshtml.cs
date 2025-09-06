using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class IndexModel : PageModel
{
	public IndexModel() : base()
	{
	}

	/// <summary>
	/// Handler
	/// </summary>
	public void OnGet()
	{
		// باید همیشه حواسمان باشد که خطاها را مدیریت کنیم
		// ولی فرض کنید که در جایی (مثل این محل) فراموش کرده‌ایم
		//try
		//{
		//}
		//catch (Exception ex)
		//{
		//}

		var errorMessage =
			"Connection to SQL Server Error! Username: sa, Password: 12345";

		throw new Exception(message: errorMessage);
	}
}
