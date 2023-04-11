using System.ComponentModel.DataAnnotations.Schema;

namespace DigitopiaQuest.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string NameOfMovie { get; set; } = string.Empty;
        public int AgeOfRating { get; set; }
        public double ImdbRating { get; set; }
        public string GenreOfMovie { get; set; } = string.Empty;
        public string DescriptionOfMovie { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public DateTime ReleaseDateOfMovie { get; set; }
        public TimeSpan TimeDuration { get; set; }
        public byte[]? ImageOfMovie { get; set; }
        [NotMapped]
        public List<string>? CastOfMovie { get; set; }
        public double RatingOfMovie { get; set; }
    }
}
