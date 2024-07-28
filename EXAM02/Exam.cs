using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public abstract class Exam
    {

        public int Time { get; set; }
        public int NumOfQues { get; set; }
        public List<Question> Question { get;  set; }

        public Exam(int time, int numOfQues)
        {
            Time = time;
            NumOfQues = numOfQues;
            Question = new List<Question>();
           
        }



        public abstract void ShowExam();


    }




    public class FinalExam : Exam
    {
        public FinalExam(int time, int numOfQues) : base(time, numOfQues)
        {
        }

        public override void ShowExam()
        {
            foreach (var question in Question)
            { 
                question.Display();
            foreach (var answer in question.Answer)
                Console.WriteLine(answer);
            }

            Console.WriteLine("Grade");

        }
    }




    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numOfQues) : base(time, numOfQues)
        {
        }

        public override void ShowExam()
        {
            foreach (var question in Question)
            { 
                question.Display();
            
            }


            Console.WriteLine("Right Answer After Exam");

        }
    }

}
