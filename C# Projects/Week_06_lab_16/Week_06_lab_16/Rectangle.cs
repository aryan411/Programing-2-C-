using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16
{
    class Rectangle : Shape
    {
        private double _area;
        public override double Area { get => this._area; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(string name, double height, double width): base(name)
        {
            this.Width = width;
            this.Height = height;
            this._area = this.Width * this.Height;
        }
    }
}
