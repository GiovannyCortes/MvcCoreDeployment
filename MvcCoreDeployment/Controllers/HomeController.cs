using Microsoft.AspNetCore.Mvc;
using MvcCoreDeployment.Models;
using System.Diagnostics;

namespace MvcCoreDeployment.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            ViewData["SALUDO"] = "Bienvenido a los lunes!!!!!";
            Random random = new Random();
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 15; i++) {
                numeros.Add(random.Next(1, 100));
            }
            return View(numeros);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
