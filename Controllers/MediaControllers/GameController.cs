using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Jogos";
            return View();
        }
    }
}
