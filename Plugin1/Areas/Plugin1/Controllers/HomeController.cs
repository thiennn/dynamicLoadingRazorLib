using Microsoft.AspNetCore.Mvc;
using Plugin1.Areas.Plugin1.ViewModels;

namespace Plugin1.Areas.Plugin1.Controllers
{
    [Area("Plugin1")]
    public class HomeController : Controller
    {
        [HttpGet("/plugin1")]
        public IActionResult Index()
        {
            var model = new MyViewModel
            {
                Id = 10,
                Name = "Super coool"
            };

            return View(model);
        }

        [HttpGet("/plugin1/test")]
        public IActionResult Test()
        {
            return View();
        }
    }
}
