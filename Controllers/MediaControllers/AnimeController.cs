using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Animes";
            return View();
        }
    }
}
