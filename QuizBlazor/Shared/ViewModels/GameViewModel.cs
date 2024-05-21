using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBlazor.Shared.ViewModels
{
    public class GameViewModel
    {
        public int GameId { get; set; }
        public int GamePoint { get; set; }
        public int QuizId { get; set; }
        public int UserId { get; set; }
    }
}
