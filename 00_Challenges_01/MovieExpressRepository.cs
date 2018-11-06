using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges_01
{
    class MovieExpressRepository : IMovieExpress
    {
        private Customer _customer;
        private Movie _movie;
        private List<Movie> _movieList;
        private bool _isForeign;
        private string _userName;
        private int _age;
        private string _email;
        private string _phone;

        public void AddMovieToList(Movie movie)
        {
            _movieList.Add(movie);
        }

        public Movie CreateMovie()
        {
            Console.Write("Enter movie title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the movie length (hrs): ");
            double length = double.Parse(Console.ReadLine());

            GenreType genre = GenreSwitch();

            RatingType rating = RatingSwitch();

            Console.WriteLine("Is this a foreign movie? y/n");
            string foreignRsp = Console.ReadLine();
            if (foreignRsp == "y" || foreignRsp == "Y")
                _isForeign = true;
            else
                _isForeign = false;

            Movie movie = new Movie(title, genre, length, rating, _isForeign);
            return movie;
        }

        public GenreType GenreSwitch()
        {
            GenreType genre;
            Console.WriteLine($" Which genre is your movie?\n\t" +
                $"1. Horror\n\t" +
                $"2. Action\n\t" +
                $"3. Adventure\n\t" +
                $"4. Comedy\n\t" +
                $"5. Romance\n\t" +
                $"6. Family\n\t" +
                $"7. Suspense\n\t" +
                $"8. Holiday\n\t");
            int genreRsp = int.Parse(Console.ReadLine());
            switch (genreRsp)
            {
                case 1:
                    genre = GenreType.Horror;
                    return genre;
                case 2:
                    genre = GenreType.Action;
                    return genre;
                case 3:
                    genre = GenreType.Adventure;
                    return genre;
                case 4:
                    genre = GenreType.Comedy;
                    return genre;
                case 5:
                    genre = GenreType.Romance;
                    return genre;
                case 6:
                    genre = GenreType.Family;
                    return genre;
                case 7:
                    genre = GenreType.Suspense;
                    return genre;
                default:
                    genre = GenreType.Holiday;
                    return genre;
            }
        }

        public void Initialize()
        {
            Customer initialCustomer = new Customer("Ransford", 27, "Test@test.com", "800-123-3443");
            Movie movieOne = new Movie("Star Wars", GenreType.Adventure, 1.25, RatingType.PG13, false);
            Movie movieTwo = new Movie("Boss Baby", GenreType.Comedy, 1.5, RatingType.G, false);
            AddMovieToList(movieOne);
            AddMovieToList(movieTwo);
        }

        public RatingType RatingSwitch()
        {
            RatingType rating;

            Console.WriteLine($"What is your movie's rating?\n\t" +
                $"1. G\n\t" +
                $"2. PG\n\t" +
                $"3. PG13\n\t" +
                $"4. R\n\t" +
                $"5. NR");
            int ratingRsp = int.Parse(Console.ReadLine());
            switch (ratingRsp)
            {
                case 1:
                    rating = RatingType.G;
                    break;
                case 2:
                    rating = RatingType.PG;
                    break;
                case 3:
                    rating = RatingType.PG13;
                    break;
                case 4:
                    rating = RatingType.R;
                    break;
                default:
                    rating = RatingType.NR;
                    break;
            }
            return rating;
        }

        public void Register()
        {
            Console.Write("Enter your name: ");
            _userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            _age = int.Parse(Console.ReadLine());
            Console.Write("Enter your email: ");
            _email = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            _phone = Console.ReadLine();
            _customer = new Customer()
            {
                Name = _userName,
                Age = _age,
                Email = _email,
                PhoneNumber = _phone,
                FavoriteMovies = _movieList
            };
        }

        public void RemoveMovieFromList()
        {
            Console.Write("Enter the name of the movie you would like to remove: ");
            string removeName = Console.ReadLine();
            foreach (Movie movie in _movieList)
            {
                if (movie.Title == removeName)
                {
                    _movieList.Remove(movie);
                    break;
                }
            }
        }

        public void SeeAllMovies()
        {
            foreach (Movie movie in _movieList)
            {
                Console.WriteLine($"Title: {movie.Title} Genre: {movie.Genre} Movie Length: {movie.MovieLength} hrs Rating: {movie.MovieRating} Foreign Status {movie.IsForeign}");
            }
        }

        public void UpdateMovie()
        {
            Console.Write("Enter the name of the movie you would like to update: ");
            string updateName = Console.ReadLine();
            foreach (Movie movie in _movieList)
            {
                if (movie.Title == updateName)
                {
                    Console.Write($"Would you like to update Title: {movie.Title}?");
                    if (YesNoResponse())
                    {
                        Console.Write("Enter new title: ");
                        movie.Title = Console.ReadLine();
                    }
                    Console.Write($"Would you like to update Length: {movie.MovieLength}?");
                    if (YesNoResponse())
                    {
                        Console.Write("Enter updated length: ");
                        movie.MovieLength = double.Parse(Console.ReadLine());
                    }
                    Console.Write($"Would you like to update Genre: {movie.Genre}?");
                    if (YesNoResponse())
                        movie.Genre = GenreSwitch();
                    Console.Write($"Would you like to update Rating: {movie.MovieRating}?");
                    if (YesNoResponse())
                        movie.MovieRating = RatingSwitch();
                    Console.WriteLine($"Would you like to update foreign movie status: {movie.IsForeign}?");
                    if (YesNoResponse())
                    {
                        Console.WriteLine("Is this a foreign movie? y/n");
                        if (YesNoResponse())
                            movie.IsForeign = true;
                        else
                            movie.IsForeign = false;
                    }
                    break;
                }
            }
        }

        public bool YesNoResponse()
        {
            string response = Console.ReadLine();
            if (response == "y" || response == "Y")
                return true;
            else
                return false;
        }
    }
}
