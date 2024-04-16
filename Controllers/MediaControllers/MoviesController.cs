using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    [Route("Movies")]
    [Route("Filmes")]
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Filmes";
            return View();
        }
    }
}
