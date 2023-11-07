using reviewPlataform.Models.Media;
using reviewPlataform.Models.Media.Comments;

namespace reviewPlataform.Models.Media
{
    public abstract class Media
    {
        public Guid Id { get; set; }
        public int NegativePoints { get; set; }
        public int PositivePoints { get; set; }
        public List<Comment> Comments { get; set; }
        public string Title { get; set; }

        protected Media(int negativePoints, int positivePoints, List<Comment> comments, string title)
        {
            Id = new Guid();
            NegativePoints = negativePoints;
            PositivePoints = positivePoints;
            Comments = comments;
            Title = title;
        }

    }
}