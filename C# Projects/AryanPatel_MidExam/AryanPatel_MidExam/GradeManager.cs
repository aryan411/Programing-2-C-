using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AryanPatel_MidExam
{
    // Static Grade manager class
    static class GradeManager
    {
        // private static field
        private static List<Student> students = new List<Student>();
        // load students from file into list
        public static void LoadStudents(string file)
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string sl in lines)
            {
                string[] words = sl.Split(' ');
                students.Add(new Student(words[0], words[1], words[2], Double.Parse(words[3]), Double.Parse(words[4]), Double.Parse(words[5])));

            }
            
        }
        // additonal method to load static list
        private static List<Student> CreateStudents()
        {
            List<Student> result = new List<Student>(){
            new Student("Sahasan","123-4567","COMP123", 8, 17, 60),
            new Student ("Kassie", "234-5678", "COMP123", 10, 20, 65),
            new Student ("Maiara", "345-6789","COMP123", 7, 18, 58),
            new Student ("Laura", "456-7890", "COMP123", 9, 19, 40),
            new Student ("Aaron", "678-9012", "COMP123", 7, 17, 50),
            new Student ("Diego", "789-0123", "COMP123", 9, 19, 60),
            new Student ("Jancyben", "890-1234", "COMP123", 9, 19, 45),
            new Student ("Laila", "901-2345","COMP123", 9, 15, 55),
            new Student ("Enas", "123-9012", "COMP123", 7, 17, 57),
            new Student ("Mel", "234-0123","COMP123", 9, 16, 47),
            new Student ("Deep", "345-1234","COMP123", 9, 19, 63),
            new Student ("Palk", "456-8901", "COMP123", 8, 8, 25)
            };
            return result;
        }
        // All static methods
        public static void Show()
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s.ToString());
            }
        }
        public static void Above(double selectedMark)
        {
            foreach (Student s in students)
            {
                if(s.Total > selectedMark)
                Console.WriteLine(s.ToString());
            }
        }
        public static double Average()
        {
            double sum = 0;
            foreach (Student s in students)
            {
                sum += s.Total;
            }
            Console.WriteLine(sum / students.Count());
            return sum / students.Count();
        }
        public static void Top()
        {
            double max = 0;
            Student topper = new Student();
            foreach (Student s in students)
            {
                if (s.Total > max)
                {
                    topper = s;
                    max = s.Total;
                }
            }
            Console.WriteLine($"Name: { topper.Name }, Marks: {topper.Total}");

        }
    }
}
