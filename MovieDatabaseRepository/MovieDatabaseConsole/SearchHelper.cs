using MovieDatabaseDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseConsole
{
    public class SearchHelper
    {
        //public List<Movie> SearchByTitle()
        //{
        //    Console.Clear();
        //    List<Book> titleSearchResultsList = new List<Book>();
        //    Console.WriteLine(" ---------------------------");
        //    Console.WriteLine("| Check Out / Returns / Ban |");
        //    Console.WriteLine(" ---------------------------\n");
        //    Console.Write("Please enter a title to search by: ");
        //    string titleSearchString = Console.ReadLine().ToLower();

        //    foreach (var result in bookList.Where(x => x.Title.ToLower().IndexOf(titleSearchString) == 0))
        //    {
        //        titleSearchResultsList.Add(result);
        //    }

        //    if (titleSearchResultsList.Count > 0)
        //    {
        //        Console.Clear();
        //        Console.WriteLine(" ---------------------------");
        //        Console.WriteLine("| Check Out / Returns / Ban |");
        //        Console.WriteLine(" ---------------------------\n");
        //        Console.WriteLine($"Found {titleSearchResultsList.Count} book(s)");

        //        for (int i = 0; i < titleSearchResultsList.Count; i++)
        //        {
        //            Console.WriteLine($"{i + 1}.) {titleSearchResultsList[i].Title} by {titleSearchResultsList[i].Author}");
        //        }

        //        Console.Write("\nPlease enter the number of the book you'd like to choose: ");

        //        int userInt = Validator.GetNumberInRange(1, titleSearchResultsList.Count);
        //        Book userBook = titleSearchResultsList[userInt - 1];
        //        return userBook;



        //    }
        //    else if (!titleSearchResultsList.Any())
        //    {
        //        Console.Clear();
        //        Console.WriteLine(" ---------------------------");
        //        Console.WriteLine("| Check Out / Returns / Ban |");
        //        Console.WriteLine(" ---------------------------\n");
        //        Console.WriteLine($"A book with the title '{titleSearchString}' was not found.");
        //        Console.ForegroundColor = ConsoleColor.DarkGray;
        //        Console.WriteLine("\n ------------------------");
        //        Console.WriteLine("| Returning to main menu |");
        //        Console.WriteLine(" ------------------------\n");
        //        Console.ForegroundColor = ConsoleColor.White;
        //        MenuClass.MainMenu(library);
        //        //return to main menu
        //    }

        //    //not sure what I should put for the return here, still working on this
        //    throw new Exception("SearchByTitle Method Exception");
        //}

        //public static List<Movie> SearchByTitle()
        //{





        //}

        //public static List<Movie> SearchByTitle()
        //{
        //    //List<Movie> movieTitleSearchResultsList = new List<Movie>();
        //    List<Movie> movieTitleSearchResultsList = new List<Movie>();
        //    public List<Movie> GetMovieTitle(string userTitle)
        //    Console.Clear();
        //    Console.Write("Please enter the movie title to search by: ");
        //    string movieSearchString = Console.ReadLine().ToLower();

        //    foreach (var result in movieTitleSearchResultsList.Where(x => x.Title.ToLower().IndexOf(movieSearchString) == 0))
        //    {
        //        movieTitleSearchResultsList.Add(result);
        //    }

        //    if (movieTitleSearchResultsList.Count > 0)
        //    {
        //        Console.Clear();
        //        Console.WriteLine($"Found {movieTitleSearchResultsList.Count} movie(s)");

        //        for (int i = 0; i < movieTitleSearchResultsList.Count; i++)
        //        {
        //            Console.WriteLine($"{movieTitleSearchResultsList[i].Title}");
        //        }

        //        return movieTitleSearchResultsList;
        //    }
        //    else if (!movieTitleSearchResultsList.Any())
        //    {
        //        Console.Clear();

        //        Console.WriteLine($"Movie '{movieSearchString}' not found.");
        //        MenuClass.MainMenu();
        //    }


        //    throw new Exception("SearchByAuthor Method Exception");
        //}
    }
}
