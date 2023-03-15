using Microsoft.AspNetCore.Mvc;

namespace Imshop.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
