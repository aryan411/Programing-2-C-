using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03_lab_08_09
{
    public static class Library
    {
        private static List<Song> songs = new List<Song>(); 

        public static void DisplaySongs()
        {
            foreach(Song s in songs)
            {
                Console.WriteLine(s.ToString());
            }

        }
        public static void DisplaySongs(double longerThan)
        {
            foreach (Song s in songs)
            {
                if (s.Length > longerThan)
                {
                    Console.WriteLine(s.ToString());
                }
            }

        }
        public static void DisplaySongs(SongGenre genre)
        {
            
            foreach (Song s in songs)
            {
                if(s.Genre.HasFlag(genre))
                Console.WriteLine(s.ToString());
            }

        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song s in songs)
            {
                if(s.Artist == artist)
                Console.WriteLine(s.ToString());
            }

        }
        public static void LoadSongs(string fileName)
        {
            List<string> lines = new List<string>();
            // Create a stream reader object to read a text file.
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = string.Empty; // Contains a single line returned by the stream reader object.

                // While there are lines in the file, read a line into the line variable.
                while ((line = reader.ReadLine()) != null)
                {
                    // If the line is not empty, add it to the list.
                    if (line != string.Empty)
                    {
                        lines.Add(line);
                    }
                }
            }
            //string[] lines = (string[])temp

            for ( int i = 0; i < lines.Count(); i = i+4 ) 
            {
                var name = lines[i+1];
                var title = lines[i];
                var genre =(SongGenre) Enum.Parse(typeof(SongGenre), lines[i + 3]);
                var length  = Double.Parse( lines[i+2] );

                songs.Add(new Song(title, name, length, genre));
            }

        }

    }
}
