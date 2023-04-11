using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitopiaQuest.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string NameOfMovie { get; set; } = string.Empty;
        [DisplayName("Age Rating")]
        public int AgeOfRating { get; set; }
        [DisplayName("imdb Rating")]
        public double ImdbRating { get; set; }
        [DisplayName("Genre")]
        public string GenreOfMovie { get; set; } = string.Empty;
        [DisplayName("Description")]
        public string DescriptionOfMovie { get; set; } = string.Empty;
        [DisplayName("Director")]
        public string Director { get; set; } = string.Empty;
        [DisplayName("Release Date")]
        public DateTime ReleaseDateOfMovie { get; set; }
        [DisplayName("Time Duration")]
        public TimeSpan TimeDuration { get; set; }
        [DisplayName("Image")]
        public byte[]? ImageOfMovie { get; set; }
        [DisplayName("Cast")]
        [NotMapped]
        public List<string>? CastOfMovie { get; set; }
        [DisplayName("Score of users")]
        public double RatingOfMovie { get; set; }
    }
}
