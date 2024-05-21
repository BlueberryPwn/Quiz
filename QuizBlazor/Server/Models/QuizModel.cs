using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizBlazor.Server.Models
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
