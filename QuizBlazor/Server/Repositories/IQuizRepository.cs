using QuizBlazor.Shared.ViewModels;
using System.Security.Claims;

namespace QuizBlazor.Server.Repositories
{
    public interface IQuizRepository
    {
        List<QuizViewModel> GetAllQuizzes();
        List<QuestionViewModel> GetQuestionsByQuizId(int QuizId);
        string GetUserId();
        List<ResultViewModel> GetUserResult();
        List<QuizViewModel> GetQuizzesByUserId();
    }
}
