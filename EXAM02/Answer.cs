using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public  class Answer
    {

        public int AnswerId { get; set; }
        public string AnswerName { get; set; }

        public Answer(int answerId, string answerName)
        {
            AnswerId = answerId;
            AnswerName = answerName;
        }

        public override string ToString()
        {
            return AnswerName;
        }





    }
}
