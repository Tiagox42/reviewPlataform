using Microsoft.AspNetCore.Mvc;

namespace reviewPlataform.Controllers
{
    public class Movie : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
