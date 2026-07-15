using Microsoft.AspNetCore.Mvc;
using Practical_1_Writeup.Models;

namespace Practical_1_Writeup.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentResultModel s)
        {
            s.Total = s.Sub1 + s.Sub2 + s.Sub3 + s.Sub4 + s.Sub5;

            s.Percentage = s.Total / 5.0;

            if (s.Percentage >= 75)
                s.Grade = "A";
            else if (s.Percentage >= 60)
                s.Grade = "B";
            else if (s.Percentage >= 50)
                s.Grade = "C";
            else
                s.Grade = "Fail";

            return View(s);
        }
    }
}
