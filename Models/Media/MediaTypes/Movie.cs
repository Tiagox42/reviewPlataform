using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace reviewPlataform.Models.Media.MediaTypes
{
    public class Movie : Media
    {
        [Display(Name = "Diretor")]        
        public string? Director { get; set; }

        [Display(Name = "Gênero")]
        public string? Genre { get; set; }

        [Display(Name = "Lançamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateOnly? Release { get; set; }

        [Display(Name = "Classificação")]
        public AgeRating? AgeRating { get; set; }

        [Display(Name = "Sinopse")]
        public string? Synopsis { get; set; }

        [Display(Name = "Elenco")]
        public string? Actors { get; set; }

        [Display(Name = "Duração")]
        [DataType(DataType.Time)]
        public TimeOnly? Duration { get; set; }

        [Display(Name = "Língua original")]
        public string? Language { get; set; }

        [Display(Name = "Páis de Origem")]
        public string? ContryOrigin { get; set; }

        [Display(Name = "Título Original")]
        public string? OriginalTitle { get; set; }

        [Display(Name = "Produtora")]
        public string? ProductionStudio { get; set; }

        [Display(Name = "Trailer")]
        [DataType(DataType.Url)]
        public string? Trailer { get; set; }

        [Display(Name = "Descrição")]
        public string? Description { get; set; }

        [Display(Name = "Valor de produção")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal? Budget { get; set; }

        [Display(Name = "Roteiro")]
        public string? Script { get; set; }

        public Movie()
        {
        }

        public Movie(
            int negativePoints, int positivePoints, string title, MediaType type,
            string? director, string? genre, DateOnly? release, AgeRating? ageRating, string? synopsis, string? actors,
            TimeOnly? duration, string? language, string? contryOrigin, string? originalTitle, string? productionStudio, string? trailer,
            string? description, decimal? budget, string? script) : 
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
            OriginalTitle = originalTitle;
            Script = script;

        }
    }
}
