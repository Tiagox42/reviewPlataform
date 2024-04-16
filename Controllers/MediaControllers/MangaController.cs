using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class MangaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Mangá";
            return View();
        }
    }
}
