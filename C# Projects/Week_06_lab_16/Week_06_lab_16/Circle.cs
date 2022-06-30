using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16
{
    class Circle : Square
    {
        private double _area;
        public override double Area 
        {
            get
            {
                return this._area;
            }
        }
        public Circle(string name, double length) : base(name,length)
        {
            this._area = Math.PI * length * length;
        }
    }
}
