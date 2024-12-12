using API_Example_Ryan.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using moviesAPI.Models;

namespace API_Example_Ryan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _movieService;

        // Have ASP.NET dependency inject service into the class
        public MovieController(MovieService movieService)
        {
            // assign the D.I. service object to our reference for it
            _movieService = movieService;
        }

        // Controller to retrieve and return all movies from MovieService
        [HttpGet("movies")]
        public Task<List<Movie>> GetMovies()
        {
            // AsyncCallback the MovieService to retrieve all the movies and return them
            return _movieService.AllTheMovies();
        }

        [HttpPost("movies")]
        public Task<List<Movie>> newMovie()
        {
        // AsyncCallback the MovieService to retrieve all the movies and return them
            return _movieService.AllTheMovies();
        }   
    }
}
