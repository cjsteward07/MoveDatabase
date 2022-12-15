using MovieDatabaseDTO;
using System;
using System.Collections.Generic;
using MovieDatabaseDomain;
namespace MovieDatabaseConsole
{
    public class SearchHelper
    {
        public static void SearchByTitle(MovieInteractor _movieInteractor)
        {
            Console.Clear();
            Console.Write("Please enter the movie title to search by: ");
            string movieSearchString = Console.ReadLine().ToLower();
            foreach (Movie movie in _movieInteractor.GetMovieTitle(movieSearchString))
            {
                Console.WriteLine($"{movie.Title}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        public static void SearchByGenre(MovieInteractor _movieInteractor)
        {
            Console.Clear();
            Console.Write("Please enter the genre to search by: ");
            string movieSearchString = Console.ReadLine().ToLower();
            foreach (Movie movie in _movieInteractor.GetMovieGenre(movieSearchString))
            {
                Console.WriteLine($"{movie.Title}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
