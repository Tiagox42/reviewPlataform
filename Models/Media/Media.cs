using reviewPlataform.Models.Media;
using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;

namespace reviewPlataform.Models.Media
{
    public abstract class Media
    {
        public Guid Id { get; set; }
        public int? NegativePoints { get; set; }
        public int? PositivePoints { get; set; }
        public int? ReviewPoints { get; set; }
        public string Title { get; set; }
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
            Title = title;
            Type = type;
        }

    }
}