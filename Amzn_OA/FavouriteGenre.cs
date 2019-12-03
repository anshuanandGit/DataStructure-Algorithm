using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class FavouriteGenre
    {
        public static void Start()
        {
            Dictionary<string, List<string>> UserSongs = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> Genre = new Dictionary<string, List<string>>();

            UserSongs.Add("David", new List<string> { "song1", "song2", "song3", "song4", "song8" });
            UserSongs.Add("Emma", new List<string> { "song5", "song6", "song7" });

            Genre.Add("Rock", new List<string> { "song1",  "song3" });
            Genre.Add("Dubstep", new List<string> {  "song7" });
            Genre.Add("Techno", new List<string> { "song2",  "song4" });
            Genre.Add("Pop", new List<string> { "song5", "song6" });
            Genre.Add("Jazz", new List<string> { "song9", "song8" });

            Dictionary<string, List<string>> op = FavGenre(UserSongs, Genre);

            foreach(var key in op.Keys)
            {
                Console.WriteLine(key+" : "+String.Join(",",op[key]));
            }
            
         }

        public static Dictionary<string, List<string>> FavGenre(Dictionary<string, List<string>> UserSongs, Dictionary<string, List<string>> Genre)
        {
            Dictionary<string, List<string>> Result = new Dictionary<string, List<string>>();
            Dictionary<string, string> GenreMap = new Dictionary<string, string>();

            foreach (var key in Genre.Keys)
            {
                List<string> songs = Genre[key];
                foreach (var s in songs)
                {
                    GenreMap.Add(s, key);
                }
            }

           foreach(var usr in UserSongs.Keys)
            {
                List<string> songs = UserSongs[usr];
                Dictionary<string, int> counter = new Dictionary<string, int>();
                List<string> genre = new List<string>();

                foreach (var s in songs)
                {
                    string gnr = GenreMap[s]; //pull genre for songs.....
                    if (counter.ContainsKey(gnr))
                    {
                        counter[gnr] += 1;
                    }
                    else
                    {
                        counter.Add(gnr, 1);
                    }
                }
                int max = 0;
                foreach(var cntr in counter)
                {
                    if (cntr.Value > max)
                    {
                        max = cntr.Value;
                        genre.Clear(); //remove past entries .....
                        genre.Add(cntr.Key); //add genre with highest count
                    }
                    else if(cntr.Value == max)//more than one genra with same value
                    {
                        genre.Add(cntr.Key); 
                    }

                }

                Result.Add(usr, genre);

            }

            return Result;
        }
    }
}
