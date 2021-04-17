using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntDesign;

namespace Client.Model
{
    public class Film
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int CriticScore{ get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre FilmGenre { get; set; }
        public decimal NetEarnings { get;set;}
        public bool IsProfitable { get; set; }

        public Film()
        {
            //parameterless constructor is necessary to enable the "New" button on grids, else adding will throw exception
            FilmGenre = new Genre(0, "Unknown");
            Title = "New Film";
        }


        public Film(string title, int score, DateTime release, Genre g, decimal earnings, bool isProfitable)
        {
            Title = title;
            CriticScore = score;
            ReleaseDate = release;
            FilmGenre = g;
            NetEarnings = earnings;
            IsProfitable = isProfitable;
        }

        public static List<Film> GetNewList(List<Genre> genres)
        {
            var lst = new List<Film>();

            var counter = 1;
            var score = 1;
            foreach (var g in genres)
            {
                lst.Add(new Film($"Film {counter}", score,DateTime.Today.AddDays(-counter), g, (counter * 2.3M + score * 3.2M),true));
                counter += 1;
                score += 1;
                if (score >= 6) score = 1;

                lst.Add(new Film($"Film {counter}", score, DateTime.Today.AddDays(-counter), g, (counter * 6.9M + score * 7.8M), false));
                counter += 1;
                score += 1;
                if (score >= 6) score = 1;

                lst.Add(new Film($"Film {counter}", score, DateTime.Today.AddDays(-counter), g, (counter * 1.3M + score * 13.9M), true));
                counter += 1;
                score += 1;
                if (score >= 6) score = 1;
            }

            return lst;
        }
    }

    public class Genre
    {
        public int Code { get;set;}
        public string Name { get;set; }

        public Genre(int cd, string nm)
        {
            Code = cd;
            Name = nm;
        }

        public static List<Genre> GetNewList()
        {
            var Genres = new List<Genre>();
            Genres.Add(new Genre(1, "Horror"));
            Genres.Add(new Genre(2, "Sci Fi"));
            Genres.Add(new Genre(3, "Comedy"));
            Genres.Add(new Genre(4, "RomCom"));
            return Genres;
        }
    }
}
