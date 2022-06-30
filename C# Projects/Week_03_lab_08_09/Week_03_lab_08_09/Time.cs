using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_lab_08_09
{
    // Time format enum 
    enum TimeFormat
    {
        Mil,
        Hour12,
        Hour24
    }
    // time class
    class Time
    {
        
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12; // propety
        public int Hour { get; } // propety
        public int Min { get; } // propety
        // constructor
        public Time(int hour = 0, int minute = 0)
        {
            this.Hour = hour <=24 && hour >= 0 ? hour : 0;
            this.Min = minute <= 60 && minute >= 0 ? minute : 0;
        }
        // tostring() function
        public override string ToString()
        {
            string fmt = "00";
            // switch statment to select time format
            switch (Time.TIME_FORMAT)
            {
                case TimeFormat.Hour24:
                    return $"{this.Hour.ToString(fmt)}:{this.Min.ToString(fmt)}";

                case TimeFormat.Mil:
                    return $"{this.Hour.ToString(fmt)}{this.Min.ToString(fmt)}";
                case TimeFormat.Hour12:
                default:
                    {
                        if (Hour > 12)
                        {
                            return $"{(this.Hour - 12).ToString(fmt)}:{this.Min.ToString(fmt)} PM";
                        }
                        else
                        {
                            return $"{this.Hour.ToString(fmt)}:{this.Min.ToString(fmt)} AM";
                        }
                    }
                
            }

        }
        // set time format function
        public static void SetTimeFormat(TimeFormat time_format)
        {
            Time.TIME_FORMAT = time_format;
        }
    }
}
