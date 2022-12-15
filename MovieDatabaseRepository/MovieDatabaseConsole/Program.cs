using MovieDatabaseDomain;
using MovieDatabaseDTO;
using MovieDatabaseRepository;
using Microsoft.Extensions.Options;
using MovieDatabaseConsole;

MovieInteractor _movieInteractor = new MovieInteractor();

//void LoadStartUpData()
//{
//    foreach (Movie item in BuildItemCollection())
//    {
//        if (_movieInteractor.AddNewItem(item) == true)
//        {
//            Console.WriteLine($"{item.Title} was added to the database.");
//        }
//        else
//        {
//            Console.WriteLine($"{item.Title} was NOT added to the database.");
//        }
//    }
//}

//List<Movie> BuildItemCollection()
//{
//    List<Movie> initialItems = new List<Movie>();
//    initialItems.Add(new Movie() { Title = "Dumb and Dumber", Genre = "Comedy", Runtime = 19 });
//    initialItems.Add(new Movie() { Title = "Gladiator", Genre = "Action", Runtime = 155 });
//    initialItems.Add(new Movie() { Title = "Top Gun", Genre = "Action", Runtime = 110 });
//    initialItems.Add(new Movie() { Title = "Dumbo", Genre = "Musical", Runtime = 64 });
//    initialItems.Add(new Movie() { Title = "Nightmare Before Christmas", Genre = "Fantasy", Runtime = 76 });
//    initialItems.Add(new Movie() { Title = "Saw", Genre = "Horror", Runtime = 200 });
//    initialItems.Add(new Movie() { Title = "The Lord Of The Rings", Genre = "Fantasy", Runtime = 178 });
//    initialItems.Add(new Movie() { Title = "Batman: The Dark Knight", Genre = "Action", Runtime = 92 });
//    initialItems.Add(new Movie() { Title = "The Mummy", Genre = "Adventure", Runtime = 124 });
//    initialItems.Add(new Movie() { Title = "Jurassic Park", Genre = "Adventure", Runtime = 127 });
//    initialItems.Add(new Movie() { Title = "Terminator 2", Genre = "Thriller", Runtime = 152 });
//    initialItems.Add(new Movie() { Title = "Black Hawk Down", Genre = "Action", Runtime = 152 });
//    initialItems.Add(new Movie() { Title = "Ace Ventura", Genre = "Comedy", Runtime = 86 });
//    initialItems.Add(new Movie() { Title = "Remember The Titans", Genre = "Drama", Runtime = 120 });
//    initialItems.Add(new Movie() { Title = "The Iron Giant", Genre = "Adventure", Runtime = 86 });

//    return initialItems;
//}

//LoadStartUpData();
Console.WriteLine("Hello");


MenuClass.MainMenu();














Console.ReadKey();





