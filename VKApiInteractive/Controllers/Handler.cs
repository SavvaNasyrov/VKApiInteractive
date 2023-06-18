using Microsoft.AspNetCore.Mvc;

namespace VKApiInteractive.Controllers
{
    public class Handler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
