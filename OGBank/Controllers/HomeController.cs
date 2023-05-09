using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OGBank.Models;
using System.Diagnostics;

namespace OGBank.Controllers
{
  //  [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewBalance()
        {
            return View();
        }

        public IActionResult PayTax()
        {
            return View();
        }

        public IActionResult Paid()
        {
            return View();
        }

        public IActionResult ViewTransactions()
        {
            return View();
        }

        public IActionResult SetInferiorLimit()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize]
        public IActionResult MyAccount()
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