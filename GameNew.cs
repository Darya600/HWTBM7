using System;
using System.Collections.Generic;
using System.Text;

namespace HWTBM7
{
    class GameNew
    {
        public void StartGame()
        {
            Questions [] question = CreateQuestionList();
            question[0].Answer = CreateAnswerList();

            Console.WriteLine(question[0].QuestionText);
        }
        private  Questions [] CreateQuestionList()
                {
                Questions [] question = new Questions[3];
                question[0] = new Questions("This year is....");
                question[1] = new Questions("This month is...");
                question[2] = new Questions("This century is...");
                return question;
                }
        private Answers [] CreateAnswerList()
        {
            Answers[] answer = new Answers[4];
            answer[0] = new WrongAnswer("2020");
            answer[1] = new CorrectAnswer("2021");
            answer[2] = new WrongAnswer("1990");
            answer[3] = new WrongAnswer("1991");

            return answer;
        }
        
    }
}
