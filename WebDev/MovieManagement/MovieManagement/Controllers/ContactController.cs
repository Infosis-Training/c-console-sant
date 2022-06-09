using Microsoft.AspNetCore.Mvc;

namespace MovieManagement.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
