using Microsoft.AspNetCore.Mvc;
using Practical1MVC.Models;

namespace Practical1MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new AddModel());
        }

        [HttpPost]
        public IActionResult Index(AddModel model)
        {
            model.Result = model.A + model.B;
            return View(model);
        }
    }
}