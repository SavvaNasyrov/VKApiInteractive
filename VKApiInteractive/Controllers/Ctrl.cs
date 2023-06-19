using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using System.Diagnostics;
using VKApiInteractive.Models;

namespace VKApiInteractive.Controllers
{
    public class Ctrl : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Ctrl(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string ids) 
        {
            Handler handler = new Handler();
            string res = handler.HandleUsersGet(ids);
            return View();
        }

        public IActionResult UsersGet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExecuteUsersGetAsync(string ids)
        {
            Handler handler = new Handler();
            string res = handler.HandleUsersGet(ids);
            return View(res);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
