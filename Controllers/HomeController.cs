using Microsoft.AspNetCore.Mvc;

namespace _932020.Rybatsky.Kirill.lab11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
