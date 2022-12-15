using MovieDatabaseDomain;
namespace MovieDatabaseConsole
{

    public static class MenuClass
    {
        public static void MainMenu(MovieInteractor _movieInteractor)
        {
            Console.WriteLine("What would like to do");
            Console.WriteLine("1.) Search By Title");
            Console.WriteLine("2.) Search By Genre");
            Console.WriteLine("3.) Quit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    SearchHelper.SearchByTitle(_movieInteractor);
                    break;
                case 2:
                    SearchHelper.SearchByGenre(_movieInteractor);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}