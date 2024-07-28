using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public abstract class Question
    {

        public string Header { get; set; }
        public string Body   { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answer { get; set; }
        public Answer RightAnswer { get; set; }

       
     

        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answer = new List<Answer>();
        }

        public abstract void Display();

     
    }


    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}:::{Body}");
            Console.WriteLine("1.True");
            Console.WriteLine("2.False");
        }
    }



    public class TrueFalse : Question
    {
        public TrueFalse(string header, string body, int mark) : base(header, body, mark)
        {

        }

        public override void Display()
        {
            Console.WriteLine($"{Header}:::{Body}");
            for (int i = 0; i < Answer.Count; i++)
                Console.WriteLine($"{i + 1}::{Answer[i].AnswerName}");



        }
    }






















 }
