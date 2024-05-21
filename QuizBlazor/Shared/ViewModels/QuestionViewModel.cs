using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBlazor.Shared.ViewModels
{
    public class QuestionViewModel
    {
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
    }
}
