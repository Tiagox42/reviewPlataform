using Microsoft.AspNetCore.Mvc;
using reviewPlataform.Models.Media;
using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;
using System.ComponentModel.DataAnnotations;

namespace reviewPlataform.Models.Media
{
    public abstract class Media
    {
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "ID")]
        public Guid Id { get; set; }

        [Display(Name = "Pontuação Negativa")]
        public int? NegativePoints { get; set; }

        [Display(Name = "Pontuação Positiva")]
        public int? PositivePoints { get; set; }

        [Display(Name = "Pontos de Review")]
        public int? ReviewPoints { get; set; }

        [Display(Name = "Nome", Order = 1)]
        public string Name { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Tipo")]
        public MediaType Type { get; set; }

        public Media()
        {
        }

        public Media(int negativePoints, int positivePoints, string title, MediaType type)
        {
            Id = Guid.NewGuid();
            NegativePoints = negativePoints;
            PositivePoints = positivePoints;
            ReviewPoints = 0;
            Name = title;
            Type = type;
        }

    }
}