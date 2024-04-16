using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class ComicsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Quadrinhos";
            return View();
        }
    }
}
