﻿namespace QuizApp.Models
{
    public class Answer
    {
        public string? Text { get; set; }
        public int Points { get; set; }

        public bool IsCorrect { get; set; }
    }
}
