using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;

namespace reviewPlataform.Models.Media.MediaTypes
{
    public class Movie : Media
    {
        public string? Director { get; set; }
        public string? Genre { get; set; }
        public DateTime? Release { get; set; }
        public string? AgeRating { get; set; }
        public string? Synopsis { get; set; }
        public List<string>? Actors { get; set; }
        public TimeOnly? Duration { get; set; }
        public string? Language { get; set; }
        public string? ContryOrigin { get; set; }
        public string? ProductionStudio { get; set; }
        public string? Trailer { get; set; }

        public Movie()
        {
        }

        public Movie(int negativePoints, int positivePoints, string title, MediaType type) : base(negativePoints, positivePoints, title, type)
        {
            //Type = MediaType.Movie;
            Director = null;
            Genre = null;
            Release = null;
            AgeRating = null;
            Synopsis = null;
            Actors = new List<string>();
            Duration = null;
            Language = null;
            ContryOrigin = null;
            ProductionStudio = null;
            Trailer = null;
        }
    }
}
