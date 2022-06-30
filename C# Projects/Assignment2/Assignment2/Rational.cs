using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    // Rational class
    class Rational
    {
        public int Denominator { get; private set; } // property
        public int Numerator { get; private set; } // property
        // constructor with default values
        public Rational( int numerator=0, int denominator = 1)
        {
            this.Denominator = denominator;
            this.Numerator = numerator;
        }
        // toString override function
        public override string ToString()
        {
            double temp = (double)this.Numerator / this.Denominator;
            return $"{this.Numerator} / {this.Denominator} or ({(double)temp})";
        }
        // increaseby method
        public void IncreaseBy(Rational other)
        {
            this.Denominator = this.Denominator * other.Denominator;
            this.Numerator = (this.Numerator * other.Denominator) + (other.Numerator * this.Denominator);
        }
        // decrease by method
        public void DecreaseBy(Rational other)
        {
            var tempD = this.Denominator * other.Denominator;
            var one = this.Numerator * other.Denominator;
            var two = other.Numerator * this.Denominator;
            this.Numerator = one - two;
            this.Denominator = tempD;
        }

    }
}
