using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Models;

namespace TestSystem.Data
{
    public static class DataAccessLayer
    {
        public static List<Question> GetQuestions()
        {
            TestSystemContext context = new TestSystemContext();
            return context.Question.ToList();
        }
    }
}
