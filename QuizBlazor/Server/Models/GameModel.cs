using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizBlazor.Server.Models
{
    public class GameModel
    {
        [Key]
        public int GameId { get; set; }
        public int GamePoint {  get; set; }
        public int QuizId { get; set; }

        [ForeignKey("QuizId")]
        public QuizModel QuizModel { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
