using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace StackOverflow.Models
{
    public class DAL
    {
        public static string currentUser = null;

        public static MySqlConnection DB;

        public static List<Question> GetAllQuestions()
        {
            return DB.GetAll<Question>().ToList();
        }

        public static Question GetQuestion(int id)
        {
            return DB.Get<Question>(id);
        }

        

        public static QuestionWithAnswers GetQuestionWithAnswers(int theQId)
        {
            var keyvalues = new { qId = theQId };
            string sql = "select * from answers where questionId = @qId";
            QuestionWithAnswers qa = new QuestionWithAnswers();
            qa.Answers = DB.Query<Answer>(sql, keyvalues).ToList();
            qa.Question = DAL.GetQuestion(theQId);
            return qa;

        }

        
        public static void AddQuestion(Question question)
        {
            question.Username = DAL.currentUser;
            DB.Insert<Question>(question);
        }

        public static void UpdateQuestion(Question question)
        {
            question.Username = DAL.currentUser;
            DB.Update<Question>(question);
        }

        public static void DeleteQuestion(int id)
        {
            Question question = new Question() { Id = id };
            DB.Delete<Question>(question);
        }

        public static List<Answer> GetAllAnswers()
        {
            return DB.GetAll<Answer>().ToList();
        }

        public static Answer GetAnswer(int id)
        {
            return DB.Get<Answer>(id);
        }

        public static void AddAnswer(Answer answer)
        {
            answer.Username = DAL.currentUser;
            DB.Insert<Answer>(answer);
        }

        public static void UpdateAnswer(Answer answer)
        {
            answer.Username = DAL.currentUser;
            DB.Update<Answer>(answer);
        }

        public static void DeleteAnswer(int id)
        {
            Answer answer = new Answer() { Id = id };
            DB.Delete<Answer>(answer);
        }

        public static List<Question> SearchQuestions(string str)
        {
            var keyValuePair = new { search = $"%{str}%" };
            string sql = "select * from questions where detail like @search or title like @search or category like @search";
            return DB.Query<Question>(sql, keyValuePair).ToList();
        }








    }
}
