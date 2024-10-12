using Microsoft.AspNetCore.Mvc;
using Practice6.Models;
using System.Diagnostics;

namespace Practice6.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Users()
		{
			return View();
		}

	}
}
