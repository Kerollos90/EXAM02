using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteExam02
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();
    }

    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            int totalScore = 0;
            int totalMarks = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

                #region Check Answer && add Mark

            foreach (var question in Questions)
            {
                question.Display();

                int userAnswerId = question.GetUserAnswer();
                var userAnswer = question.Answers[userAnswerId - 1];
                
                Console.Write($"Right Answer => {question.RightAnswer.AnswerText}\n");
                if (userAnswer.AnswerId == question.RightAnswer.AnswerId)
                {
                    totalScore += question.Mark;
                }

                totalMarks += question.Mark;

            }
            stopwatch.Stop();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"|  Time {stopwatch.Elapsed}\n|  Your Grade is {totalScore} from {totalMarks}\n|  Thank You ");
            Console.WriteLine("-----------------------------------");

            #endregion

        }
    }


    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            #region Check Answer only

            foreach (var question in Questions)
            {
                question.Display();
                int userAnswerId = question.GetUserAnswer();
                var userAnswer = question.Answers[userAnswerId - 1];

                Console.WriteLine($"Right Answer => {question.RightAnswer.AnswerText}\n");
            } 


            stopwatch.Stop();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"| Time {stopwatch.Elapsed}\n| Thank You ");
            Console.WriteLine("-----------------------------------");
            #endregion
        }
    }


}
