using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; }
        public Movie(string name, int year, int length)
        {
            this.Title = name;
            this.Year = year;
            this.Length = length;
            this.Cast = new List<string>();
        }
        public void AddActor(string actor)
        {
            this.Cast.Add(actor);
        }
        public void SetGenre(Genre genre)
        {
            this.Genre = genre;
        }
        public override string ToString()
        {
            return $"\nTitle:- {this.Title} ({this.Year.ToString()})\n" +
                $"\nLength:- {this.Length.ToString()} min\n" +
                $"\nGenre:- {this.Genre.ToString()}\n" +
                $"\nCast:- { String.Join(", ", Cast)}\n";
        }
    }
}
