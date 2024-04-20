using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Livros";
            return View();
        }
    }
}
