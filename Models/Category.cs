using QuizApp.Models;
using System.Collections.Generic;

namespace QuizApp.Models
{
    public class Category
    {
        public string? CategoryName { get; set; }
        public List<Question>? Questions { get; set; }
    }
}
