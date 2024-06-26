﻿using reviewPlataform.Models.Media.Comments;
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

        public Game()
        {
        }

        public Game(int negativePoints, int positivePoints, string title, MediaType type) : base(negativePoints, positivePoints, title, type)
        {
            //Type = MediaType.Game;
            Developer = null;
            Publisher = null;
            ReleaseDate = null;
            Platforms = new List<string>();
            Genre = null;
            AgeRating = null;
            Trailer = null;
            SteamID = null;
        }
    }
}
