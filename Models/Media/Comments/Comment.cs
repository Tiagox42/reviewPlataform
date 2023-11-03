using reviewPlataform.Models.Media.Comments.Enums;
using reviewPlataform.Models.Person;

namespace reviewPlataform.Models.Media.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }
        public User user { get; set; }
        public string text { get; set; }
        public int likes { get; set; }
        public int dislike { get; set; }
        public CommentStatus status { get; set; }
        public DateTime? created { get; set; } = DateTime.MinValue;
        public DateTime? updated { get; set; }
        public DateTime? lastUpdated { get; set;}
        public DateTime? deleted { get; set; }
        public DateTime? updatedBy { get; set;}
        public DateTime? createdBy { get; set;}

        //HistoricoDeText um dia
        
    }
}
