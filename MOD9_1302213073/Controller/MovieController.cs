
using Microsoft.AspNetCore.Mvc;

namespace MOD9_1302213073.Controller
{
    public class MovieController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class MovieController : ControllerBase
        {
            public static List<Movie> ListMovies = new List<Movie>
            {
                new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>{"Tim Robbins", "Morgan Freeman","Bob Gunton","William Sadler"}, "Over the course of several years, two convicts from a friendship, seeking consolation and, eventually, redemption throught basic commpassion."),
                new Movie("The Godfather", "Francis  Ford Coppola", new List<string>{"Al Pacino", "Marlon Brando", "James Caan", "Diane Keaton"}, "The aging patriach of an organized crime dynasty in postwar New York  City transfer control of his clandestine empire to his reluctant youngtest son." ),
                new Movie("The Dark Knight", "Christoper Nolan", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one the greatest psycological and physical test of his ability to fight injustice."}),
            };
            [HttpGet]
            public IEnumerable<Movie> Get()
            {
                return ListMovies;
            }

            [HttpGet("{id}")]
            public Movie Get(int id)
            {
                return ListMovies[id];
            }
            [HttpPost]
            public void Post(Movie value)
            {
                ListMovies.Add(value);
            }
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                ListMovies.Remove(id);
            }
        }
    }
}
public