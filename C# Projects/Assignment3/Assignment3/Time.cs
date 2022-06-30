using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public Time(int hours,int minutes=0)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }
        public override string ToString()
        {
            return $"{this.Hours.ToString()}:{this.Minutes.ToString()}";
        }
        public static bool operator ==(Time lhs,Time rhs)
        {
            if ((lhs.Minutes + lhs.Hours * 60) == (rhs.Hours * 60 + rhs.Minutes))
            {
                return true;
            }
            else return false;
            
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            if ((lhs.Minutes + lhs.Hours * 60) == (rhs.Hours * 60 + rhs.Minutes))
            {
                return false;
            }
            else return true;
        }
    }
}
