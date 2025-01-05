using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using TodoList.Models;

namespace TodoList.Controllers
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
			var userId = HttpContext.Session.GetString("AuthId");

            if (userId != null)
            {
                return View("index");
            }

			return Redirect("/User/index");
		}

		public IActionResult Privacy()
		{
            return View();
        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
