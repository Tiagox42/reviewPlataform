using reviewPlataform.Models.Media.Comments;
using reviewPlataform.Models.Media.MediaTypes.Enums;

namespace reviewPlataform.Models.Media.MediaTypes
{
    public class Game : Media
    {

        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public List<string>? Platforms { get; set; }
        public string? Genre { get; set; }
        public string? AgeRating { get; set; }
        public string? Trailer { get; set; }
        public string? SteamID { get; set; }

        public Game(int negativePoints, int positivePoints, List<Comment> comments, string title, MediaType type) : base(negativePoints, positivePoints, comments, title, type)
        {
            type = MediaType.Game;
        }
    }
}
