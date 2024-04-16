using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Séries";
            return View();
        }
    }
}
