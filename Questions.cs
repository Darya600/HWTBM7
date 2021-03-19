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
        }
        public string QuestionText
            {
            get;
            private set;
            }
        public Answers[] Answer;

    }
}
