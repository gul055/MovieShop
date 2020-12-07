using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Models.Request;
using MovieShop.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IUserService _userService;

        public AdminController(IMovieService movieService, IUserService userService)
        {
            _movieService = movieService;
            _userService = userService;
        }


        [HttpPost]
        [Route("movie")]
        public async Task<IActionResult> CreateMovie(MovieCreateRequest movieCreateRequest)
        {
            var createdMovie = await _movieService.CreateMovie(movieCreateRequest);

            return Ok(createdMovie);
        }

        [HttpPut]
        [Route("movie")]
        public async Task<IActionResult> UpdateMovie(MovieCreateRequest movieCreateRequest)
        {
            var updatedMovie = await _movieService.UpdateMovie(movieCreateRequest);

            return Ok(updatedMovie);
        }

        [HttpGet]
        [Route("purchases")]
        public async Task<IActionResult> GetAllPurchases(int pageSize = 30, int page = 1)
        {
            return Ok();
        }

        [HttpGet]
        [Route("top")]
        public IActionResult GetTopMovies()
        {
            return Ok();
        }
    }
}
