using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesDemo
{
    internal class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Quiz { get; set; }
        public double Midterm { get; set; }
        public double Final { get; set; }
        public double TotalCourseGrade
        {
            get
            {
                double quizGrd = (Quiz / 50) * 20;
                double midtermGrd = (Midterm / 50) * 30;
                double finalGrd = (Final / 100) * 50;
                return quizGrd + midtermGrd + finalGrd;
            }
        }
        public string GradeLetterString
        {
            get
            {
                if(TotalCourseGrade >= 95.0)
                {
                    return "A+";
                }else if(TotalCourseGrade >= 90.0)
                {
                    return "A";
                }else if(TotalCourseGrade >= 85.0 )
                {
                    return "A-";
                }else if(TotalCourseGrade >= 80.0)
                {
                    return "B+";
                }else if(TotalCourseGrade >= 75.0)
                {
                    return "B";
                }else if(TotalCourseGrade >= 70.0)
                {
                    return "B-";
                }else if(TotalCourseGrade >= 65.0)
                {
                    return "C+";
                }else if(TotalCourseGrade >= 60.0)
                {
                    return "C";
                }else if(TotalCourseGrade >= 55.0)
                {
                    return "C-";
                }else if(TotalCourseGrade >= 50.0)
                {
                    return "P";
                }
                else
                {
                    return "F";
                }
            }
        }

        public Student(string id, string firstName, string lastName, int quiz, int midterm, int final)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Quiz = quiz;
            Midterm = midterm;
            Final = final;
        }

        public override string ToString()
        {
            string outputStudentGrd = String.Format("{0, -20}{1, -20}{2,-20}{3,-20}{4,-15}{5,-15}{6,-15}{7,-15}",
                Id, FirstName, LastName, Quiz, Midterm, Final, TotalCourseGrade, GradeLetterString);
            return outputStudentGrd;
        }
    }
}
