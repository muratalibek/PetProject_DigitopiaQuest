using System.ComponentModel;

namespace DigitopiaQuest.Models
{
    public class Book
    {
        public int Id { get; set; }
        [DisplayName("Book Name")]
        public string NameOfBook { get; set; } = string.Empty;
        [DisplayName("Book Description")]
        public string DescriptionOfBook { get; set; } = string.Empty;
        [DisplayName("Book Author")]
        public string AuthorOfBook { get; set; } = string.Empty;
        [DisplayName("Book Reliese Date")]
        public DateTime RelieseDateOfBook { get; set; }
        [DisplayName("Book Rating")]
        public double RatingOfBook { get; set; }
    }
}
