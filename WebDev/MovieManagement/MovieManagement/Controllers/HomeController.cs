using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}