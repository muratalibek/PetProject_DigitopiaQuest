using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DigitopiaQuest.Models
{
    public class Game
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string NameOfGame { get; set; } = string.Empty;
        [DisplayName("Description")]
        public string DescriptionOfGame { get; set; } = string.Empty;
        [DisplayName("Score")]
        public double UserScore { get; set; }
        [DisplayName("Release")]
        public DateTime ReleaseDateOfGame { get; set; }
        [DisplayName("Genre")]
        public string GenreOfGame { get; set; } = string.Empty;
        [DisplayName("Developer")]
        public string Developer { get; set; } = string.Empty;
        [DisplayName("Company")]
        public string DevCompany { get; set; } = string.Empty;
        [DisplayName("Image")]
        public byte[]? ImageOfMovie { get; set; }
    }
}
