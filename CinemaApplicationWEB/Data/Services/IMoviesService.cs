using CinemaApplicationWEB.Data.Base;
using CinemaApplicationWEB.Models;
using System.Threading.Tasks;

namespace CinemaApplicationWEB.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);
    }
}
