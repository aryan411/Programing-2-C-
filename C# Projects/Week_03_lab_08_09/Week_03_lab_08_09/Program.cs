using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_lab_08_09
{
    class Program
    {
        public static void timeDriver()
        {
            //create a list to store the objects
            List<Time> times = new List<Time>()
            {
                new Time(9, 35),
                new Time(18, 5),
                new Time(20, 500),
                new Time(10),
                new Time()
            };
            //display all the objects
            TimeFormat format = TimeFormat.Hour12;
            Console.WriteLine($"\n\nTime format is {format}");
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            //change the format of the output
            format = TimeFormat.Mil;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetTimeFormat(format);
            //again display all the objects
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
            //change the format of the output
            format = TimeFormat.Hour24;
            Console.WriteLine($"\n\nSetting time format to {format}");
            //SetFormat(TimeFormat) is a class member, so you need the type to access it
            Time.SetTimeFormat(format);
            foreach (Time t in times)
            {
                Console.WriteLine(t);
            }
        }
        public static void songDriver()
        {
            //To test the constructor and the ToString method
            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));
            //This is first time that you are using the bitwise or. It is used to specify combination of genres
            Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26,
            SongGenre.Country | SongGenre.Rock));
            Library.LoadSongs("Week_03_lab_09_songs4.txt");     //Class methods are invoke with the class name
            Console.WriteLine("\n\nAll songs");
            Library.DisplaySongs();
            SongGenre genre = SongGenre.Rock;
            Console.WriteLine($"\n\n{genre} songs");
            Library.DisplaySongs(genre);
            string artist = "Bob Dylan";
            Console.WriteLine($"\n\nSongs by {artist}");
            Library.DisplaySongs(artist);
            double length = 5.0;
            Console.WriteLine($"\n\nSongs more than {length}mins");
            Library.DisplaySongs(length);


        }
        static void Main(string[] args)
        {
            timeDriver();
            songDriver();
        }
    }
}
