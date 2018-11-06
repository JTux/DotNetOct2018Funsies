using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges_01
{
    interface IMovieExpress
    {
        void Initialize();
        void AddMovieToList(Movie movie);
        Movie CreateMovie();
        void Register();
        void RemoveMovieFromList();
        GenreType GenreSwitch();
        RatingType RatingSwitch();
        void SeeAllMovies();
        void UpdateMovie();
        bool YesNoResponse();
    }
}
