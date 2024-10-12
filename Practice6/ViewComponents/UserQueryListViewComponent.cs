using Microsoft.AspNetCore.Mvc;

namespace Practice6.ViewComponents
{
	public class UserQueryListViewComponent : ViewComponent
	{
		List<string> _users;
		public UserQueryListViewComponent() 
		{
			_users = new List<string>()
			{
				"Tom", "Serhii", "Tim", "Kate"
			};
		}
		public IViewComponentResult Invoke()
		{
			int number = _users.Count;

			if (Request.Query.ContainsKey("number"))
			{
				Int32.TryParse(Request.Query["number"].ToString(), out number);
			}

			ViewBag.Users = _users.Take(number);
			ViewData["Header"] = $"Users count : {number}";
			return View();
		}
	}
}
