using Microsoft.AspNetCore.Mvc;
using VKApiInteractive.Models;

namespace VKApiInteractive.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<Models.ResultViewModel> Post([FromForm] UsersGetModel2 model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (string.IsNullOrWhiteSpace(model.Id))
                return BadRequest(new ResultViewModel ("is null or white space"));

            var result = new ResultViewModel(model.Id);

            return View("ResultView", result);
        }
    }
}
