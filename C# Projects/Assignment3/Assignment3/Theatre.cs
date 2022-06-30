using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Theatre
    {
        private List<Show> show;
        public string Name { get; }
        public Theatre(string name)
        {
            this.Name = name;
            this.show = new List<Show>();
        }
        public void AddShow(Show show)
        {
            this.show.Add(show);
        }
        public void PrintShows()
        {
            foreach(var s in show)
            {
                Console.WriteLine(s.ToString());
            }         
        }
        public void PrintShows(Genre genre)
        {
            foreach (var s in show)
            {
                if(s.Movie.Genre.HasFlag(genre))
                Console.WriteLine(s.ToString());
            }
        }
        public void PrintShows(Day day) 
        {
            foreach (var s in show)
            {
                if(s.Day == day)
                Console.WriteLine(s.ToString());
            }
        }
        public void PrintShows(Time time)
        {
            foreach (var s in show)
            {
                if (s.Time == time)
                Console.WriteLine(s.ToString());
            }
        }
        public void PrintShows(string actor)
        {
            foreach (var s in show)
            {
                if(s.Movie.Cast.Contains(actor))
                Console.WriteLine(s.ToString());
            }
        }
        public void PrintShows(Day day, Time time)
        {
            foreach (var s in show)
            {
                if(s.Day == day && s.Time == time)
                Console.WriteLine(s.ToString());
            }
        }
    }
}
