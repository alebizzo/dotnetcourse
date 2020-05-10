using Microsoft.AspNetCore.Mvc;

namespace dotnetcourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono la pagina home!");
        }
    }
}