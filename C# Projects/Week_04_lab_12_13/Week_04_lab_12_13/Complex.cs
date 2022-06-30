using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_04_lab_12_13
{
    class Complex
    {
        public int Real { get;}
        public int Imaginary { get;}
        public double Argument { get;}
        public double Modulus { get;}
        public static Complex Zero = new Complex();

        public Complex (int real=0, int imaginary=0)
        {
            this.Real = real;
            this.Imaginary = imaginary;
            
            this.Modulus = Math.Sqrt((Math.Pow(this.Real, 2) + Math.Pow(this.Imaginary, 2)));
            if (real == 0)
                this.Argument = double.PositiveInfinity;
            else this.Argument = Math.Atan(this.Imaginary / this.Real);
        }
        public override string ToString()
        {
            return $"{this.Real} + i({this.Imaginary})";

        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
                return true;
            else return false;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
                return false;
            else return true;
        }
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            int real = lhs.Real*rhs.Real - lhs.Imaginary * rhs.Imaginary;
            int imaginary = lhs.Real * rhs.Imaginary - rhs.Imaginary * lhs.Real;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex rhs)
        {
            return new Complex(-rhs.Real, -rhs.Imaginary);
        }


    }
}
