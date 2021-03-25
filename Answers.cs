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

       
        public  int AnswerNumber
        {
            get;
            private set;
        }

        public Answers(int AnswerNumber, string AnswerText)
        {
            this.AnswerText = AnswerText;
            this.AnswerNumber = AnswerNumber;
        }
    }
    class WrongAnswer : Answers
    {
        public WrongAnswer(int AnswerNumber, string AnswerText) : base(AnswerNumber, AnswerText)
        { 
        }

    }

    class CorrectAnswer: Answers
    {
        public CorrectAnswer(int AnswerNumber, string AnswerText):base(AnswerNumber, AnswerText)
        {     
        }
    }
}
