using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers.MediaControllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Teste";
            return View();
        }
    }
}
