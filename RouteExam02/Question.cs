using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace RouteExam02
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; }
        public Answer RightAnswer { get; set; }


        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new List<Answer>();
        }

        public abstract void Display();

        public abstract int GetUserAnswer();
       
        
    }

    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark) { }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body}");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }

        public override int GetUserAnswer()
        {
            
           
            
            int answer = int.Parse(Console.ReadLine());
            return answer;

        }

        
    }




    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark) { }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body}");
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].AnswerText}");
            }
        }


      

        public override int GetUserAnswer()
        {
           
            Console.Write("Your Answer => ");
            
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }

        
    }




}
