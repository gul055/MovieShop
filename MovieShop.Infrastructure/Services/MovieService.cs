using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.Models.Request;
using MovieShop.Core.Models.Response;
using MovieShop.Core.RepositoryInterfaces;
using MovieShop.Core.ServiceInterfaces;

namespace MovieShop.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<MovieDetailsResponseModel> CreateMovie(MovieCreateRequest movieCreateRequest)
        {
            throw new NotImplementedException();
        }
        /*
        public Task<PagedResultSet<MovieResponseModel>> GetAllMoviePurchasesByPagination(int pageSize = 20, int page = 0)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedList<MovieResponseModel>> GetAllPurchasesByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }*/

        public async Task<IEnumerable<MovieResponseModel>> GetHighestGrossingMovies()
        {
            var movies = await _movieRepository.GetHighestRevenueMovies();
            var movieResponseModel = new List<MovieResponseModel>();
            foreach(var movie in movies)
            {
                movieResponseModel.Add(new MovieResponseModel
                {
                    Id = movie.Id,
                    PosterUrl = movie.PosterUrl,
                    ReleaseDate = movie.ReleaseDate.Value,
                    Title = movie.Title
                });
            }
            return movieResponseModel;
        }

        public async Task<MovieDetailsResponseModel> GetMovieAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            var movieDetailsResponseModel = new MovieDetailsResponseModel();
            movieDetailsResponseModel.Id = movie.Id;
            movieDetailsResponseModel.Title = movie.Title;
            movieDetailsResponseModel.PosterUrl = movie.PosterUrl;
            movieDetailsResponseModel.BackdropUrl = movie.BackdropUrl;
            //missig rating, will talk later
            movieDetailsResponseModel.Overview = movie.Overview;
            movieDetailsResponseModel.Tagline = movie.Tagline;
            movieDetailsResponseModel.Budget = movie.Budget;
            movieDetailsResponseModel.Revenue = movie.Revenue;
            movieDetailsResponseModel.ImdbUrl = movie.ImdbUrl;
            movieDetailsResponseModel.TmdbUrl = movie.TmdbUrl;
            movieDetailsResponseModel.ReleaseDate = movie.ReleaseDate;
            movieDetailsResponseModel.RunTime = movie.RunTime;
            movieDetailsResponseModel.Price = movie.Price;
            //ignore favorite count for now
            movieDetailsResponseModel.Casts = new List<MovieDetailsResponseModel.CastResponseModel>();
            foreach(var cast in movie.MovieCasts)
            {
                movieDetailsResponseModel.Casts.Add(new MovieDetailsResponseModel.CastResponseModel 
                {
                    Id = cast.Cast.Id,
                    Name = cast.Cast.Name,
                    Gender = cast.Cast.Gender,
                    TmdbUrl = cast.Cast.TmdbUrl,
                    ProfilePath = cast.Cast.ProfilePath,
                    Character = cast.Character
                });
            }
            movieDetailsResponseModel.Genres = new List<Core.Entities.Genre>();
            foreach(var genre in movie.MovieGenres)
            {
                movieDetailsResponseModel.Genres.Add(new Core.Entities.Genre
                {
                    Id = genre.Genre.Id,
                    Name = genre.Genre.Name
                });
            }



            return movieDetailsResponseModel;
        }

        public Task<IEnumerable<MovieResponseModel>> GetMoviesByGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        /*public Task<PagedResultSet<MovieResponseModel>> GetMoviesByPagination(int pageSize = 20, int page = 0, string title = "")
        {
            throw new NotImplementedException();
        }*/

        public Task<int> GetMoviesCount(string title = "")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReviewMovieResponseModel>> GetReviewsForMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieResponseModel>> GetTopRatedMovies()
        {
            throw new NotImplementedException();
        }

        public Task<MovieDetailsResponseModel> UpdateMovie(MovieCreateRequest movieCreateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
