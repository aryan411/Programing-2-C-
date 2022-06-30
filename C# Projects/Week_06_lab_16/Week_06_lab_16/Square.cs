using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16
{
    class Square : Shape
    {
        public double Length { get; set; }
        private double _area;
        public override double Area { 
            get
               {
                return this._area;
                } 
        }
        public Square(string name, double length) : base (name)
        {
            this.Length = length;
            this._area = Math.Pow(length, 2);
        }
    }
}
