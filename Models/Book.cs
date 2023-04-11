namespace DigitopiaQuest.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string NameOfBook { get; set; } = string.Empty;
        public string DescriptionOfBook { get; set; } = string.Empty;
        public string AuthorOfBook { get; set; } = string.Empty;
        public DateTime RelieseDateOfBook { get; set; }
        public double RatingOfBook { get; set; }
    }
}
