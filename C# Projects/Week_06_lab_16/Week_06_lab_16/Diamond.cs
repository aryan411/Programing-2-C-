﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16
{
    class Diamond : Rectangle
    {
        private double _area;
        public override double Area => this._area;
        public Diamond(string name, double height, double width) : base(name, height, width)
        {
            this._area = width * height * 0.5;
        }
    }
    
}
