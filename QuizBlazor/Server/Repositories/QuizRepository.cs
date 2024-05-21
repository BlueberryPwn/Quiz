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
                .Where(q =>  q.QuizId == QuizId)
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

        public string GetUserId(ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
