using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
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
            _logger.LogInformation("Index Page Called");
            _logger.LogInformation("Error Log Called");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy Page Called");
            return View();
        }

        public IActionResult Test()
        {
            DateTime dateTime = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(dateTime + " Test Page Called");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}