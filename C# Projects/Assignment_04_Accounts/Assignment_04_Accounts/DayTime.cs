using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class DayTime
    {
        private long minutes;
        public DayTime(long minutes)
        {
            this.minutes = minutes;
        }
        public static DayTime operator +(DayTime lhs, int minutes)
        {
            lhs.minutes += minutes;
            return lhs;
        }
        public override string ToString()
        {
            
            int year = (int)(minutes / 518400);
            int mint = (int)(minutes % 518400);
            int month = mint / 43200;
            mint %= 43200;
            int day = mint / 1440;
            mint %= 1440;
            int hours = mint / 60;
            mint &= 60;

            return $"{year}-{month}-{day} {hours}:{mint}";
        }
    }
}
