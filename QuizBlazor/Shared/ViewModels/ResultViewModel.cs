using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBlazor.Shared.ViewModels
{
    public class ResultViewModel
    {
        public int QuizId { get; set; }
        public string Quiz {  get; set; }
        public int GamePoint {  get; set; }
        public string UserId { get; set; }
        public string User {  get; set; }
    }
}
