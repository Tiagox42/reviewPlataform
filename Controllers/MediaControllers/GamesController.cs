using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Jogos";
            return View();
        }
    }
}
