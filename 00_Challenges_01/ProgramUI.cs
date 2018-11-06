using System;

namespace _00_Challenges_01
{
    class ProgramUI
    {
        public void Run()
        {
            MovieExpressRepository movieXRepo = new MovieExpressRepository();
            Console.WriteLine("Welcome to movie express!\n\nWhat would you like to do?");
            bool response = true;

            while (response)
            {
                Console.WriteLine($"\t1. Register\n\t" +
                    $"2. Add a movie\n\t" +
                    $"3. Remove a movie\n\t" +
                    $"4. Update a movie\n\t" +
                    $"5. See all my movies\n\t" +
                    $"6. Exit Program");

                int menuSelection = int.Parse(Console.ReadLine());
                switch (menuSelection)
                {
                    case 0:
                        movieXRepo.Initialize();
                        break;
                    case 1:
                        movieXRepo.Register();
                        break;
                    case 2:
                        movieXRepo.AddMovieToList(movieXRepo.CreateMovie());
                        break;
                    case 3:
                        movieXRepo.RemoveMovieFromList();
                        break;
                    case 4:
                        movieXRepo.UpdateMovie();
                        break;
                    case 5:
                        movieXRepo.SeeAllMovies();
                        break;
                    default:
                        response = false;
                        break;
                }
            }
        }
    }
}