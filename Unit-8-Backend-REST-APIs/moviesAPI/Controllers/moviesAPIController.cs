using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moviesAPI.Models;
using System.Reflection.Metadata.Ecma335;

namespace moviesAPI.Controllers
{
    // sets the base URL for API calls to the controller
    // if [controller] is included it adds the controller name to the path.
    [Route("api/[controller]")]
    [ApiController]
    public class moviesAPIController : ControllerBase
    {
        // This controller will use EF to access the data in movie table

        // Define a reference to a DbContext object for the table ---- MoviedbContext
        private readonly MoviedbContext _context;

        // Constructor that assigns the Dependency Injected DbContext to our reference
        public moviesAPIController(MoviedbContext context)
        {
            _context = context;
        }

        // Methods to handle various HTTP Requests and URL paths
        // Retrieve all the rows of table - more than one row returned, so we return a list
        [HttpGet("Movie")]
        //           Task<return-type<Method>>
        public async Task<List<Movie>> getMovies()
        {
            // call EF to get all the movies and return them
            return await _context.Movies.ToListAsync();
        }

        // Add a movie to the data source
        [HttpPost("movies/create")]
        public async Task<Movie> blockBuster([Bind("MovieId, Title, ReleaseYear, Director")] Movie newMovie)
        {
            // context.operation(data)
            _context.Add(newMovie);                     // Data is added to a memory copy of the table
            await _context.SaveChangesAsync();          // Call EF to save new data in memory to data source

            return newMovie;
        }

        // Delete a movie based on id
        // use a parameter variable in the URL to get the key we want to delete
        [HttpDelete("movies/delete/{id}")]                                 
        public async Task<ActionResult<int>> deleteThisMovie(int id)
        {
            var aMovie = await _context.Movies.FindAsync(id);       // Call Entity Framework to see if tsk to be delete exists in the data source

            if (aMovie != null)                                     // If Gambler does exist...
            {
                _context.Movies.Remove(aMovie);                     //     Call Entity Framework to mark it as removed it from the data soure
                _context.SaveChanges();                             //     Save/Commit the delete in tehdata source

            }
            return Ok();
        }


        // Update a movie
        [HttpPut("movies/update")]
        public async Task<ActionResult<int>> changeMovieInfo([Bind("MovieId, Title, ReleaseYear, Director")] Movie updatedMovie)
        {
            if (ModelState.IsValid)   // check if data passed passes all validity checks....
            {
                try                                         // Attempt to...
                {
                    _context.Update(updatedMovie);          //     Call Entity Framework to update data in data source
                    await _context.SaveChangesAsync();      //     Call Entity Framework to save/commit updated data in data source
                }
                catch (DbUpdateConcurrencyException)        // If unexpected data base error occurs..
                {
                    if (MovieExists(updatedMovie.MovieId))  //      and update item exists...
                    {
                        throw;                              //          throw the exception to next process in call stack
                    }
                    else                                    //      and update item does not exist...
                    {
                        return NotFound();                  //          return with Not Found (404) HTPP status code
                    }
                }
                return Ok();                                // If update was successful, return OK (200) HTTP status code
            }
            return BadRequest();                            // Data wassed was invalid - return Bad Request (400) HTTP status code
        }

        private bool MovieExists(object id)
        {
            throw new NotImplementedException();
        }

        // Helper method to determine is a particular task exists in the data source
        private bool GamblerExists(int id)
        {
            // Call Entity Framework to determine is there is any gambler in data source with id passed
            //      and return what it returns (true if there is, false if there is not)
            return (_context.Movies?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }

    }
}
