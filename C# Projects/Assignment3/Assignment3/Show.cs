using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    

    class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
       public Show(Movie movie, Day day, double price, Time time)
        {
            this.Price = price;
            this.Day = day;
            this.Movie = movie;
            this.Time = time;
        }
        public override string ToString()
        {
            return $"\n---Movie Details----\n{this.Movie.ToString()} \n" +
                $"Release Date:- {this.Day.ToString()} \n" +
                $"\nTime of the show:- {this.Time.ToString()}\n" +
                $"\nPrice of the show:- ${this.Price.ToString()}\n";
        }
    }
}
