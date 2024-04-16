using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Livros";
            return View();
        }
    }
}
