using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace reviewPlataform.Models.Media.MediaTypes
{
    public class Movie : Media
    {
        public string? Director { get; set; }
        public string? Genre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateOnly? Release { get; set; }
        public AgeRating? AgeRating { get; set; }
        public string? Synopsis { get; set; }
        public string? Actors { get; set; }

        [DataType(DataType.Time)]
        public TimeOnly? Duration { get; set; }
        public string? Language { get; set; }
        public string? ContryOrigin { get; set; }
        public string? ProductionStudio { get; set; }

        [DataType(DataType.Url)]
        public string? Trailer { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal? Budget { get; set; }

        public Movie()
        {
        }

        public Movie(
            int negativePoints, int positivePoints, string title, MediaType type,
            string? director, string? genre, DateOnly? release, AgeRating? ageRating, string? synopsis, string? actors,
            TimeOnly? duration, string? language, string? contryOrigin, string? productionStudio, string? trailer,
            string? description, decimal? budget) : 
            base(negativePoints, positivePoints, title, type)
        {
            Director = director;
            Genre = genre;
            Release = release;
            AgeRating = ageRating;
            Synopsis = synopsis;
            Actors = actors;
            Duration = duration;
            Language = language;
            ContryOrigin = contryOrigin;
            ProductionStudio = productionStudio;
            Trailer = trailer;
            Description = description;
            Budget = budget;
        }
    }
}
