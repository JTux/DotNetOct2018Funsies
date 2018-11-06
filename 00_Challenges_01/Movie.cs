using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges_01
{
    enum GenreType { Horror = 1, Action, Adventure, Comedy, Romance, Family, Suspense, Holiday}
    enum RatingType { G = 1, PG, PG13, R, NR}

    class Movie
    {
        public string Title { get; set; }
        public GenreType Genre { get; set; }
        public double MovieLength { get; set; }
        public RatingType MovieRating { get; set; }
        public bool IsForeign { get; set; }

        public Movie(string title, GenreType genre, double length, RatingType rating, bool isForeign)
        {
            Title = title;
            Genre = genre;
            MovieLength = length;
            MovieRating = rating;
            IsForeign = isForeign;
        }
    }
}
