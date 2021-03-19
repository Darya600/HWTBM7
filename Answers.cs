using System;
using System.Collections.Generic;
using System.Text;

namespace HWTBM7
{
    abstract public class Answers
    {
        public string AnswerText
        {
            get;
            private set;
        } 
        public Answers(string AnserText)
        {
            this.AnswerText = AnswerText;
        }
    }
    class WrongAnswer : Answers
    {
        public WrongAnswer(string AnserText): base(AnserText)
        {
        }
    }
    class CorrectAnswer: Answers
    {
        public CorrectAnswer(string AnserText):base(AnserText)
        {     
        }
    }
}
