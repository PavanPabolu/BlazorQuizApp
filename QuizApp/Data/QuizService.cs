using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    internal class QuizService
    {
        private static readonly List<QuizList> Quiz;

        static QuizService()
        {
            Quiz = new List<QuizList> {
                new QuizList
                {
                    Question = "Which is the most basic programming language that Microsoft ever created?",
                    Choices = new List<string> {"Visual Basic", "Batch", "C++", "DirectX", ".NET namespace"},
                    AnswerIndex = 1,
                    Score = 1
                },
                new QuizList
                {
                    Question = "The most popular language by Microsoft is",
                    Choices = new List<string> {"C#", "Visual Basic"},
                    AnswerIndex = 0,
                    Score = 2
                }
            };
        }

        public Task<List<QuizList>> GetQuizAsync()
        {
            return Task.FromResult(Quiz);
        }
    }
}