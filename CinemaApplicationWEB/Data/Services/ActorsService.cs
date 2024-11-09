using CinemaApplicationWEB.Data.Base;
using CinemaApplicationWEB.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplicationWEB.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context): base(context)
        {

        }

    }
}
