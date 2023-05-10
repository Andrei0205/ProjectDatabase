using Microsoft.AspNetCore.Mvc;
using OGBank.Models;

namespace OGBank.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            throw new NotImplementedException();
        }
        public ActionResult Details(int Id)
        {
            if (Id < 1)
                return RedirectToAction("Index");
            var admin = new Admin(Id, "George");
            return View("Details", admin);
        }
    }
}