using System;
using System.Collections.Generic;
using System.Text;

namespace HWTBM7
{
    class Questions
    {
        public Questions(string QuestionText)
        {
            this.QuestionText = QuestionText;
            this.QuestionNumber = 0;
        }
        public string QuestionText
            {
            get;
            private set;
            }
        public Answers[] Answer;
        public int QuestionNumber
        {
            get;
            private set;

        }


    }
}
