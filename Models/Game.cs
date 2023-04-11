using Microsoft.EntityFrameworkCore;

namespace DigitopiaQuest.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string NameOfGame { get; set; } = string.Empty;
        public string DescriptionOfGame { get; set; } = string.Empty;
        public double UserScore { get; set; }
        public DateTime ReleaseDateOfGame { get; set; }
        public string GenreOfGame { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public string DevCompany { get; set; } = string.Empty; 
    }
}
