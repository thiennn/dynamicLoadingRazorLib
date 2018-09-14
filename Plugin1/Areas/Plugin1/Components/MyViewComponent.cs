using Microsoft.AspNetCore.Mvc;
using Plugin1.Areas.Plugin1.ViewModels;

namespace Plugin1.Areas.Plugin1.Components
{
    public class MyViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new MyViewModel
            {
                Id = 20,
                Name = "Awesome"
            };

            return View(model);
        }
    }
}
