using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Data;
using TestSystem.Models;

namespace TestSystem.Services
{
    public class TestSystemService
    {
        private List<Question> questions;
        //private Question currentQuestion;
        private int score;
        private int numQuestion = 0;

        public int Score 
        {
            get { return score; } 
        }

        public string CurrentQuestionContent
        {
            get { return questions[numQuestion].Content; }
        }

        public TestSystemService()
        {
            questions = new List<Question>();
        }

        public void SetQuestions(List<Question> questions)
        {
            this.questions = questions;
        }

        public bool CheckAnswer(string userAnswer)
        {
            var boolUserAnswer = userAnswer == "YES" ? true : false;
            if (questions[numQuestion].Answer == boolUserAnswer) 
            {
                score++;
            }

            if (numQuestion < questions.Count - 1)
            {
                numQuestion++;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
