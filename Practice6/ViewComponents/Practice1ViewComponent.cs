using Microsoft.AspNetCore.Mvc;
using Practice6.Models;
using System.Reflection;

namespace Practice6.ViewComponents
{
    public class Practice1ViewComponent : ViewComponent
    {
        List<User> _users;

        public Practice1ViewComponent() 
        {
			_users = new List<User>()
			{
				new User() { Name = "Serhii", Age = 22, Record = 100 },
				new User() { Name = "Andrii", Age = 30, Record = 95 },
				new User() { Name = "Olha", Age = 28, Record = 90 },
				new User() { Name = "Iryna", Age = 25, Record = 85 },
				new User() { Name = "Mykola", Age = 33, Record = 80 },
				new User() { Name = "Oksana", Age = 26, Record = 75 },
				new User() { Name = "Vasyl", Age = 24, Record = 70 },
				new User() { Name = "Kateryna", Age = 29, Record = 65 },
				new User() { Name = "Dmytro", Age = 31, Record = 60 },
				new User() { Name = "Svitlana", Age = 27, Record = 55 },
				new User() { Name = "Petro", Age = 23, Record = 50 },
				new User() { Name = "Yulia", Age = 32, Record = 45 },
				new User() { Name = "Ihor", Age = 21, Record = 40 },
				new User() { Name = "Bohdan", Age = 34, Record = 35 },
				new User() { Name = "Nadiya", Age = 20, Record = 30 }
			};

		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			ViewBag.Users = _users;
			return await Task.FromResult((IViewComponentResult)View(_users));
		}
	}
}
