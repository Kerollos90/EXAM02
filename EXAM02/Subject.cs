using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    internal class Subject : ICloneable,IComparable<Subject>
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }



        public Subject(int subjectId, string subjectName, Exam exam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Exam = exam;
        }

        public Exam CraeteExam()         
        { 
            return Exam;    
        
        
        }






        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Subject? other)
        {
            if (other == null)                       
                return SubjectId.CompareTo(other?.SubjectId);

            return -1;
            
            
            
            
        }

        

        public override string ToString()
        {
            return $"(SubjectId = {SubjectId}) :: (SubjectName = {SubjectName})";
        }
    }
}
