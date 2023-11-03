namespace reviewPlataform.Models
{
    public class Movie
    {
        public string title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime Release { get; set; }
        public string IndicateRate { get; set; }
        public string Synopsis { get; set; }
        public String Actors { get; set; }
        public TimeOnly Duration { get; set; }
        public string Language { get; set; }
        public string ContryOrigin { get; set; }
        public string ProductionStudio { get; set; }
        public string Trailer { get; set; }
        public int NegativePoints { get; set; }
        public int PositivePoints { get; set; }
    }
}
