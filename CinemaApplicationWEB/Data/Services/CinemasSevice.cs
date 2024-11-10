using CinemaApplicationWEB.Data.Base;
using CinemaApplicationWEB.Models;

namespace CinemaApplicationWEB.Data.Services
{
    public class CinemasSevice : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasSevice(AppDbContext context) : base(context)
        {

        }
    }
}
