using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace DigitopiaQuest.Models
{
    public class EndUser
    {
        public int Id { get; set; }
        
        [DisplayName("Age")]
        public int AgeOfUser { get; set; }
        [DisplayName("Image")]
        public byte[]? ImageOfUser { get; set; }

    }
}
