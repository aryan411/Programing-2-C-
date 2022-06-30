using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryanPatel_MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "students.txt";
            //Load list of students from specified json file
            Console.WriteLine($"\n\nLoading list of students from file {file}");
            GradeManager.LoadStudents(file);
            Console.WriteLine("\n----------------------\n");
            //Showing all the students
            Console.WriteLine($"\n\nAll Students:");
            GradeManager.Show();
            Console.WriteLine("\n----------------------\n");
            //Showing the Students with total greater than selected mark
            int selectedMark = 50;
            Console.WriteLine($"\nStudents with total mark above { selectedMark }:");
            GradeManager.Above(selectedMark);
            Console.WriteLine("\n----------------------\n");
            //Showing the average score  
            Console.WriteLine($"\n\n Class average");
            GradeManager.Average();

            Console.WriteLine("\n----------------------\n");

            //Showing all the Students available on Tuesday @ 11:15
            Console.WriteLine($"\n\n The Highest score Obtained by:");
            GradeManager.Top();

        }
    }
}
