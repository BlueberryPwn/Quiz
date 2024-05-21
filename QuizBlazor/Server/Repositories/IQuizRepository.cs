using System.Security.Claims;

namespace QuizBlazor.Server.Repositories
{
    public interface IQuizRepository
    {
        string GetUserId(ClaimsPrincipal user);
    }
}
