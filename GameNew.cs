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
            question[0].Answer = CreateAnswerList(3,"2020", 2,"2021", 4,"2022", 1,"2019");
            question[1].Answer = CreateAnswerList(1, "December", 3, "March", 2, "October", 4, "November");
            question[2].Answer = CreateAnswerList(4, "22", 1, "21", 2, "23", 3, "20");

        }
        private  Questions [] CreateQuestionList()
                {
                Questions [] question = new Questions[3];
                question[0] = new Questions("This year is....");
                question[1] = new Questions("This month is...");
                question[2] = new Questions("This century is...");
                return question;
                }
        private Answers [] CreateAnswerList(int answerNumber1, string answer1, int answerNumber2, string answe2,
                                            int answerNumber3, string answer3, int answerNumber4, string answer4)
        {
            Answers[] answer = new Answers[4];
            answer[0] = new WrongAnswer(answerNumber1, answer1);
            answer[1] = new CorrectAnswer(answerNumber2, answe2);
            answer[2] = new WrongAnswer(answerNumber3, answer3);
            answer[3] = new WrongAnswer(answerNumber4, answer4);
            return answer;
        }
        
    }
}
