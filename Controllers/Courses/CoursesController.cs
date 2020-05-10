using Microsoft.AspNetCore.Mvc;

namespace dotnetcourse.Controllers.Courses
{
    public class CoursesController : Controller
    {
        public IActionResult Index() {
            return Content("Sono la pagina index");
        }

        public IActionResult Detail(string id) {
            return Content($"Sono la pagina di dettaglio, con id: {id}.");
        }

    }
}