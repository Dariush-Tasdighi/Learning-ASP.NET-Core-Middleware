﻿using System;
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
		//catch (System.Exception ex)
		//{
		//}

		throw new Exception
			(message: "Connection to SQL Server Error! Username: sa, Password: 12345");
	}
}
