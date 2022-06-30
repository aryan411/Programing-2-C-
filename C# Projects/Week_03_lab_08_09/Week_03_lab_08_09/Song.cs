using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_lab_08_09
{
    [Flags]
    public enum SongGenre
    {
        Unclassified = 0,
        Pop = 1,
        Rock = 2,
        Blues = 4,
        Country = 8,
        Metal = 16,
        Soul = 32
    }
    public class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public Double Length { get; }
        public SongGenre Genre { get; }
        public Song(string title, string artist, double length, SongGenre genre)
        {
            this.Artist = artist;
            this.Title = title;
            this.Length = length;
            this.Genre = genre;
        }
       
        public override string ToString()
        {
            return $"{this.Title} by {this.Artist} ({this.Genre}) {this.Length}min";    
        }
    }
}
