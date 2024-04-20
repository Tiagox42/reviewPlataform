using reviewPlataform.Data;
using reviewPlataform.Models.Media;
using reviewPlataform.Models.Media.MediaTypes;

namespace reviewPlataform.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _bancoContext;

        public MovieRepository(AppDbContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Movie Adicionar(Movie movie)
        {
            _bancoContext.Movie.Add(movie);
            _bancoContext.SaveChanges();
            return movie;
        }
    }
}
