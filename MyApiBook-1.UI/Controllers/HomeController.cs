using Microsoft.AspNetCore.Mvc;

namespace MyApiBook_1.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
