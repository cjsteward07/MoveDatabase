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

        //public List<Movie> GetAllMovies()
        //{
        //    return _repo.GetAllMovies();
        //}
        public bool AddNewItem(Movie itemToAdd)
        {
            if (string.IsNullOrEmpty(itemToAdd.Title))
            {
                throw new ArgumentException("Name and Description must contain valid text.");
            }
            return _repo.AddItem(itemToAdd);
        }
    }
}