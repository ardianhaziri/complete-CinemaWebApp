using CinemaApplicationWEB.Data.Base;
using CinemaApplicationWEB.Models;

namespace CinemaApplicationWEB.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
            
        }
    }
}
