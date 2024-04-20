using reviewPlataform.Models.Media.Comments.Enums;
using reviewPlataform.Models.User;

namespace reviewPlataform.Models.Media.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid MediaId { get; set; }
        public string Text { get; set; }
        public string? LastText { get; set; }
        public int Likes { get; set; }
        public int Dislike { get; set; }
        public CommentStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set;}
        public DateTime? Deleted { get; set; }
        public DateTime? UpdatedBy { get; set;}
        public DateTime? CreatedBy { get; set;}
        public List<Comment>? TextHistory { get; set;}

        public Comment()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
            Likes = 0;
            Dislike = 0;
            Status = CommentStatus.Basic;
            Text = string.Empty;
        }
    }
}
