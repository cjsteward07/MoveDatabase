using MovieDatabaseDTO;
using MovieDatabaseRepository;


namespace MovieDatabaseDomain
{
    public class MovieInteractor
    {
        private MovieRepository _repo;
        public MovieInteractor()
        {
            _repo = new MovieRepository();
        }
        public bool AddNewItem(Movie itemToAdd)
        {
            //TODO: check if runtime is empty as well
            if (string.IsNullOrEmpty(itemToAdd.Title) || string.IsNullOrEmpty(itemToAdd.Genre))
            {
                throw new ArgumentException("Please provide a valid name, genre, and runtime.");
            }
            return _repo.AddItem(itemToAdd);
        }
        public List<Movie> GetMovieGenre(string userGenre)
        {
            return _repo.GetMovieGenre(userGenre);
        }
        public List<Movie> GetMovieTitle(string userTitle)
        {
            return _repo.GetMovieTitle(userTitle);
        }
    }
}