using HelloApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HelloApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        [HttpGet(Name = "MoviesList")]
        public List<Movie> Names()
        {

            List<Movie> movies = new List<Movie>();

            SqlConnection connection = new("Server=(localdb)\\mssqllocaldb;Database=MovieManagement;Trusted_Connection=True;");

            SqlCommand cmd = new SqlCommand("Select * from Movies",connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movie movie = new Movie();

                movie.Id = (int)reader[0];
                movie.Name = (string)reader[1];
                movie.Description = (string)reader[2]; 
                movie.ReleaseDate = (DateTime)reader[4];

                movies.Add(movie);
            }

            reader.Close();
            connection.Close();

            return movies;

        }
    }
}
