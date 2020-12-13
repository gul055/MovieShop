using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [Route("Movies/genre/{genreId:int}")]
        public async Task<IActionResult> MovieByGenre(int genreId)
        {
            var movies = await _movieService.GetMoviesByGenre(genreId);
            return View("~/Views/Home/Index.cshtml", movies);
        }

        [Route("Movies/Details/{movieId:int}")]
        public async Task<IActionResult> Details(int movieId)
        {
            var movie = await _movieService.GetMovieAsync(movieId);
            return View(movie);
        }

    }
}
