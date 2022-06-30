using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16
{
    abstract class Shape
    {
        public string Name { get; protected set; }
        public abstract double Area { get; }
        public Shape(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Shape: {this.Name} (Area: {this.Area})\n";
        }
    }
}
