using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizBlazor.Server.Data;
using QuizBlazor.Server.Models;
using QuizBlazor.Shared.ViewModels;
using System.Security.Claims;
using QuizBlazor.Server.Repositories;

namespace QuizBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IQuizRepository _quizRepository;

        public QuizController(ApplicationDbContext context, IQuizRepository quizRepository)
        {
            _context = context;
            _quizRepository = quizRepository;
        }

        [HttpPost("PostQuestion")]
        public IActionResult CreateQuestion(QuestionViewModel questionViewModel)
        {
            var question = new QuestionModel
            {
                QuestionName = questionViewModel.QuestionName,
                QuestionAnswer = questionViewModel.QuestionAnswer,
                QuestionOption1 = questionViewModel.QuestionOption1,
                QuestionOption2 = questionViewModel.QuestionOption2,
                QuestionOption3 = questionViewModel.QuestionOption3,
                QuestionOption4 = questionViewModel.QuestionOption4,
                ImgUrl = questionViewModel.ImgUrl,
                VidUrl = questionViewModel.VidUrl,
                QuizId = questionViewModel.QuizId,
            };

            _context.Questions.Add(question);
            _context.SaveChanges();
            return Ok(question);
        }

        [HttpPost("PostQuiz")]
        public IActionResult CreateQuiz(QuizViewModel quizViewModel)
        {
            var user = _quizRepository.GetUserId();

            var quiz = new QuizModel
            {
                QuizTitle = quizViewModel.QuizTitle,
                UserId = user
            };

            _context.Quizzes.Add(quiz);
            _context.SaveChanges();
            return Ok(quiz);
        }

        [HttpGet("GetQuestionsByQuizId/{QuizId}")]
        public IActionResult GetQuestionsByQuizId(int QuizId)
        {
            var questions = _quizRepository.GetQuestionsByQuizId(QuizId);

            return Ok(questions);
        }

        [HttpGet("GetUserResult")]
        public IActionResult GetUserResult()
        {
            var user = _quizRepository.GetUserId();

            var result = _quizRepository.GetUserResult();

            return Ok(result);
        }

        [HttpGet("GetAllQuizzes")]
        public IActionResult GetAllQuizzes()
        {
            var result = _quizRepository.GetAllQuizzes();

            return Ok(result);
        }

        [HttpGet("GetUserQuizzes")]
        public IActionResult GetQuizzesByUserId()
        {
            var result = _quizRepository.GetQuizzesByUserId();

            return Ok(result);
        }
    }
}
