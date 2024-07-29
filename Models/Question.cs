using System.Collections.Generic;

namespace QuizApp.Models
{
    public class Question
    {
        public int? QuestionNumber { get; set; }
        public string? QuestionText { get; set; }
        public List<Answer>? Answers { get; set; }
    }
}
