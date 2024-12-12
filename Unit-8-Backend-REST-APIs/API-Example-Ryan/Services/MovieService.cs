using moviesAPI.Models;
using System.Net.Sockets;
using System.Text.Json;

namespace API_Example_Ryan.Services
{
    public class MovieService
    {
        // Defines an object to interact with the server
        private readonly HttpClient _httpClient;

        // Constructor
        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7223/api/MovieApi/");

        }

        // Method to get all the movies from the MovieApi
        public async Task<List<Movie>> AllTheMovies()
        {

            // Use the _httpClient to go to the server and retrieve the data
            HttpResponseMessage theResponse = await _httpClient.GetAsync("movies");

            // Get the data from the response
            String dataReturned = await theResponse.Content.ReadAsStringAsync();

            //Convert the JSON from the response to a Movie Object
            //     JsonSerializer.Deserialize<result-data-type>(dataReturned);
            return JsonSerializer.Deserialize<List<Movie>>(dataReturned);
        }

        // Post
        public async Task<Movie> CreateMovie(Movie movie)
        {
            HttpResponseMessage theResponse = await _httpClient
                .PostAsJsonAsync("movies", movie);
            theResponse.EnsureSuccessStatusCode();

            Movie? newMovie = await theResponse.Content.ReadFromJsonAsync<Movie>();
            return newMovie;
        }




    }
}
