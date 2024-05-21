using QuizBlazor.Server.Models;
using QuizBlazor.Shared.ViewModels;
using System.Security.Claims;

namespace QuizBlazor.Server.Repositories
{
    public interface IQuizRepository
    {
        List<QuizViewModel> GetAllQuizzes();
        List<QuestionViewModel> GetQuestionsByQuizId(int QuizId);
        int GetQuizId(int QuizId);
        string GetUserId();
        List<ResultViewModel> GetUserResult();
        List<QuizViewModel> GetQuizzesByUserId();
        GameModel GetGameByQuizIdAndUserId(int QuizId, string UserId);
    }
}
