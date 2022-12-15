using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseConsole
{
    public static class MenuClass
    {
        public static void MainMenu()
        {
            Console.WriteLine("What would like to do");
            Console.WriteLine("1.) Search By Title");
            Console.WriteLine("2.) Search By Genre");
            Console.WriteLine("3.) Quit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    SearchHelper.SearchByTitle();
                    break;
                //case 2:
                //    SearchByGenre();
                //    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }


        //static void SearchMenu(Library library, string action)
        //{
        //    int userChoice = 0;
        //    bool checkoutSuccess = false;
        //    if (action == "checkout")
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Book Checkout Search\n");
        //        Console.WriteLine("What would you like to search by?");
        //        Console.WriteLine("1.) Title");
        //        Console.WriteLine("2.) Author");
        //        userChoice = int.Parse(Console.ReadLine());
        //        if (userChoice == 1)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Book Checkout Search\n");
        //            Book bookToSearchFor = library.SearchByTitle(library, library.Books);
        //            checkoutSuccess = library.CheckOutBook(bookToSearchFor);
        //            if (checkoutSuccess)
        //            {
        //                Console.Clear();
        //                Console.WriteLine($"{bookToSearchFor.Title} by {bookToSearchFor.Author} has been checked out and is due back by {bookToSearchFor.DueDate}\n");
        //                Console.WriteLine("Returning to main menu\n");
        //                MainMenu(library);
        //            }
        //            else
        //            {
        //                Console.Clear();
        //                Console.WriteLine($"Sorry, {bookToSearchFor.Title} by {bookToSearchFor.Author} has already been checked out. Try again on {bookToSearchFor.DueDate} when it's due back.\n");
        //                Console.WriteLine("Returning to main menu\n");
        //                MainMenu(library);
        //            }
        //        }
        //        else if (userChoice == 2)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Book Checkout Search\n");
        //            Book bookToSearchFor = library.SearchByAuthor(library, library.Books);
        //            checkoutSuccess = library.CheckOutBook(bookToSearchFor);
        //            if (checkoutSuccess)
        //            {
        //                Console.Clear();
        //                Console.WriteLine($"{bookToSearchFor.Title} by {bookToSearchFor.Author} has been checked out and is due back by {bookToSearchFor.DueDate}\n");
        //                Console.WriteLine("Returning to main menu\n");
        //                MainMenu(library);
        //            }
        //            else
        //            {
        //                Console.Clear();
        //                Console.WriteLine($"Sorry, {bookToSearchFor.Title} by {bookToSearchFor.Author} has already been checked out. Try again on {bookToSearchFor.DueDate} when it's due back.\n");
        //                Console.WriteLine("Returning to main menu\n");
        //                MainMenu(library);
        //            }
        //        }
        //    }

        //}

    }
}