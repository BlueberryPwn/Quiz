using QuizBlazor.Server.Data;
using QuizBlazor.Shared.ViewModels;
using System.Security.Claims;

namespace QuizBlazor.Server.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly ApplicationDbContext _context;

        public QuizRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<QuizViewModel> GetAllQuizzes()
        {
            return _context.Quizzes
                .Select(q => new QuizViewModel
                {
                    QuizId = q.QuizId,
                    QuizTitle = q.QuizTitle
                })
                .ToList();
        }

        public List<QuestionViewModel> GetQuestionsByQuizId(int QuizId)
        {
            return _context.Questions
                .Where(q => q.QuizId == QuizId)
                .Select(q => new QuestionViewModel
                {
                    QuestionId = q.QuizId,
                    QuestionName = q.QuestionName,
                    QuestionAnswer = q.QuestionAnswer,
                    QuestionOption1 = q.QuestionOption1,
                    QuestionOption2 = q.QuestionOption2,
                    QuestionOption3 = q.QuestionOption3,
                    QuestionOption4 = q.QuestionOption4,
                    ImgUrl = q.ImgUrl,
                    VidUrl = q.VidUrl,
                    QuizId = QuizId
                })
                .ToList();
        }

        public List<QuizViewModel> GetQuizzesByUserId()
        {
            return _context.Quizzes
                .Where(q => q.UserId == q.UserId)
                .Select(q => new QuizViewModel
                {
                    QuizId = q.QuizId,
                    QuizTitle = q.QuizTitle
                })
                .ToList();
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        public List<ResultViewModel> GetUserResult(string UserId)
        {
            return _context.Quizzes
                .Where(q => q.UserId == UserId)
                .Join(_context.Games, q => q.QuizId, g => g.QuizId, (q, g) => new { Quiz = q, Game = g })
                .Join(_context.Users, q => q.Game.UserId, u => u.Id, (q, u) => new ResultViewModel
                {
                    Quiz = q.Quiz.QuizTitle,
                    User = u.UserName,
                    GamePoint = q.Game.GamePoint,
                })
                .ToList();
        }
    }
}
