using System;
using System.Collections.Generic;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songProps = Console.ReadLine().Split('_');

                Song song = new Song(songProps[0], songProps[1], songProps[2]);

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            CheckTypeList(typeList, songs);
        }

        public static void CheckTypeList(string typeList, List<Song> songs)
        {
            if (typeList == "all")
            {
                PrintSongs(songs);
            }
            else
            {
                PrintFilteredSongs(typeList, songs);
            }
        }

        public static void PrintSongs(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }

        private static void PrintFilteredSongs(string typeList, List<Song> songs)
        {
            foreach (Song song in songs)
            {
                if (song.TypeList == typeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
    
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
