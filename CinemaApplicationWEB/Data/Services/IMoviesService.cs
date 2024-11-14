using CinemaApplicationWEB.Data.Base;
using CinemaApplicationWEB.Data.ViewModels;
using CinemaApplicationWEB.Models;
using System.Threading.Tasks;

namespace CinemaApplicationWEB.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);

        Task UpdateMovieAsync(NewMovieVM data);
    }
}
