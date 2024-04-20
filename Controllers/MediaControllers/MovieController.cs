using Microsoft.AspNetCore.Mvc;
using reviewPlataform.Models.Media.MediaTypes;
using reviewPlataform.Repository;

namespace reviewPlataform.Controllers.MediaControllers
{

    
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Filmes";
            return View();
        }

        public IActionResult Add()
        {
            ViewData["Title"] = "Adicionar Filme";
            return View();
        }

        [HttpPost]
        public IActionResult AddRegistro(Movie Movie) {
            _movieRepository.Adicionar(Movie);
            return RedirectToAction("Index");
        }
    }
}
