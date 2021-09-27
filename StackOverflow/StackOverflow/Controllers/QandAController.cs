using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using StackOverflow.Models;


namespace StackOverflow.Controllers
{
    public class QandAController : Controller
    {
        public IActionResult Index()
        {
            List<Question> questions = DAL.GetAllQuestions();

            return View(questions);

        }


       public IActionResult QuestionAnswers(int id)
        {
            QuestionWithAnswers questionWithAnswers= DAL.GetQuestionWithAnswers(id);
            return View(questionWithAnswers);
        }

        public IActionResult AddQuestionForm(Question question)
        {
            return View(question);
        }

        public IActionResult SaveQuestion(Question question)
        {
            DAL.AddQuestion(question);
            return Redirect($"/QandA");

        }

        public IActionResult EditQuestionForm(int id)
        {
            Question question = DAL.GetQuestion(id);
            return View(question);
        }

        public IActionResult SaveChangesInQuestion(Question question)
        {
            DAL.UpdateQuestion(question);
            return Redirect($"/QandA");
        }

        public IActionResult AddAnswerForm(Answer answer)
        {
            return View(answer);
        }

        public IActionResult SaveAnswer(Answer answer, int questionId)
        {
            answer.QuestionId = questionId;
            DAL.AddAnswer(answer);
            return Redirect($"/QandA");
        }

        public IActionResult EditAnswerForm(int id)
        {
            Answer answer = DAL.GetAnswer(id);
            return View(answer);

        }

        public IActionResult UpdateAnswer(Answer answer)
        {
            DAL.UpdateAnswer(answer);
            return Redirect($"/QandA");
        }

        public IActionResult Search(string str)
        {
            List<Question> questions = DAL.SearchQuestions(str);
            return View(questions);
        }

    }

}
