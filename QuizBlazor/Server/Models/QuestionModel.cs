using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizBlazor.Server.Models
{
    public class QuestionModel
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public string QuestionAnswer { get; set; }
        public string? QuestionOption1 { get; set; }
        public string? QuestionOption2 { get; set; }
        public string? QuestionOption3 { get; set; }
        public string? QuestionOption4 { get; set; }
        public string? ImgUrl { get; set; }
        public string? VidUrl { get; set; }
        public int QuizId { get; set; }

        [ForeignKey("QuizId")]
        public QuizModel QuizModel { get; set; }
    }
}
