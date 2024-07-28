using RouteExam02;
using System.Reflection.PortableExecutable;

internal class Program
{
    public static void Main(string[] args)
    {
        #region Type&&Time&&NumQuestion
        Console.WriteLine("Please Enter The Type Of Exam (1 For Practical, 2 For Final)");
        int ExamType = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Please Enter the time For Exam From (30 min to 180 min)");
        int Time = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Please Enter the Number Of questions");
        int NumberOfQuestions = int.Parse(Console.ReadLine());
        #endregion


        


        #region Exam Question

        Exam Exam = default;

        if (ExamType == 1)
        {
            Exam = new PracticalExam(Time, NumberOfQuestions);
        }
        else if (ExamType == 2)
        {
            Exam = new FinalExam(Time, NumberOfQuestions);
        }

        for (int i = 0; i < NumberOfQuestions; i++)
        {
            Console.WriteLine("Enter the type of Question (1 for MCQ, 2 for True/False)");
            int QuestionType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the question header:");
            string Header = Console.ReadLine();

            Console.WriteLine("Enter the question body:");
            string Body = Console.ReadLine();
            Console.WriteLine("Enter the mark for this question:");
            int Mark = int.Parse(Console.ReadLine());
            Console.Clear();

            if (QuestionType == 2)
            {
                #region True False Question
                var TrurOrFalseQuestion = new TrueFalseQuestion(Header, Body, Mark);

                TrurOrFalseQuestion.Answers.Add(new Answer(1, "True"));
                TrurOrFalseQuestion.Answers.Add(new Answer(2, "False"));

                Console.WriteLine("Please Enter the right Answer id (1 for True, 2 for False):");
                int RightAnswerId = int.Parse(Console.ReadLine());
                TrurOrFalseQuestion.RightAnswer = TrurOrFalseQuestion.Answers[RightAnswerId - 1];
                Exam.Questions.Add(TrurOrFalseQuestion); 
                #endregion
            }
            else if (QuestionType == 1)
            {
                #region MCQ Question

                var McQQuestion = new MCQQuestion(Header, Body, Mark);



                Console.WriteLine("Please Enter Choice Number 1:");
                string Choice1 = Console.ReadLine();
                McQQuestion.Answers.Add(new Answer(1, Choice1));

                Console.WriteLine("Please Enter Choice Number 2:");
                string Choice2 = Console.ReadLine();
                McQQuestion.Answers.Add(new Answer(2, Choice2));

                Console.WriteLine("Please Enter Choice Number 3:");
                string Choice3 = Console.ReadLine();
                McQQuestion.Answers.Add(new Answer(3, Choice3));

                Console.WriteLine("Please Enter the right Answer id:");
                int RightChoice = int.Parse(Console.ReadLine());
                McQQuestion.RightAnswer = McQQuestion.Answers[RightChoice - 1];
                Exam.Questions.Add(McQQuestion); 
                #endregion
            }
            Console.Clear();
        } 
        #endregion

        Console.WriteLine("Please enter the subject ID:");
        int subjectId = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the subject name:");
        string subjectName = Console.ReadLine();

        var subject = new Subject(subjectId, subjectName, Exam);
        Console.Clear();


        Console.WriteLine("Do You Want To Start Exam (Y/N)");
        string startExam = Console.ReadLine().ToUpper();
        Console.Clear();

        if (startExam == "Y")
        {
            Console.WriteLine($"Exam for subject: {subject.SubjectName}");
            subject.Exam.ShowExam();
        }
        else
        {
            Console.WriteLine("Exam not started.");
        }



    }
}