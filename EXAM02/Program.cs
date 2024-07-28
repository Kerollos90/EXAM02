using EXAM02;

public class Program
{
    public static void Main(string[] args)
    {
        var McqAnswer = new List<Answer>
        { 
            
            new Answer (1,"A"),
            new Answer (2,"b"),
            new Answer (3,"c")
        };




        var TrueFalsequestion = new TrueFalse("Header 1", "Body 1", 5);


        TrueFalsequestion.Answer = McqAnswer;

        TrueFalsequestion.RightAnswer = McqAnswer[0];



        var mcqQuestion = new MCQQuestion("Header 2", "Body 2", 5);
        mcqQuestion.Answer = new List<Answer>
        {
               new Answer (1,"True"),
                new Answer (2,"False"),
                new Answer (3,"False")
        };

        mcqQuestion.RightAnswer =mcqQuestion.Answer[0];





        var FinalExam = new FinalExam(90, 3);
        FinalExam.Question.Add( TrueFalsequestion);

        FinalExam.Question.Add(mcqQuestion);

        var practicalExam = new PracticalExam(60, 3);
        practicalExam.Question.Add(TrueFalsequestion);
        var subject01 = new Subject(101, "math", FinalExam);      
        var subject02 = new Subject(102, "math", practicalExam);






        Console.WriteLine($"{subject01.SubjectName}");
        subject01.Exam.ShowExam();
        Console.WriteLine($"{subject02.SubjectName}");
        subject02.Exam.ShowExam();



















    }
}