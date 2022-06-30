using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryanPatel_MidExam
{
    class Person
    {
        public string Name { get; set; } // Property
        public string Cell { get; set; } // Property
        public Person() // constructor
        {}
        public Person(string name, string cell) //constructor
        {
            this.Name = name;
            this.Cell = cell;
        }
        public override string ToString() //method
        {
            return base.ToString();
        }
    }
}
