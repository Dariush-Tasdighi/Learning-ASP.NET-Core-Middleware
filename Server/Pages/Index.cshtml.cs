namespace Server.Pages
{
	public class IndexModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
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
			// ولی فرض کنید که در جایی (مثل این محل) فراموش کنیم
			//try
			//{
			//}
			//catch (System.Exception ex)
			//{
			//}

			throw new System.Exception
				(message: "Some Error Occured!");
		}
	}
}
