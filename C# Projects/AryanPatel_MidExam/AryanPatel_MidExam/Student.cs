using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryanPatel_MidExam
{
    class Student : Person
    {
        public string CourseName { get; set; }  // Property
        public double Quizzers { get; set; } // Property
        public double Assignment { get; set; } // Property
        public double Exams { get; set; } // Property
        public double Total { get
            {
                return this.Quizzers + this.Assignment + this.Exams;
            }
        } // Property

        // constructor
        public Student() : base()
        { }
        // constructor
        public Student(string name, string cell, string courseName, double quizzes, double assignments, double exams): base(name, cell)
        {
            this.CourseName = courseName;
            this.Quizzers = quizzes;
            this.Assignment = assignments;
            this.Exams = exams;
        }
        // toString() Method
        public override string ToString()
        {
            return $"\nName: {this.Name}   Cell:{this.Cell} CourseName: {this.CourseName} Quizzer: {this.Quizzers}  Assignments: {this.Assignment} Exams: {this.Exams}\nTotal: {this.Total}\n";
        }
    }
}
