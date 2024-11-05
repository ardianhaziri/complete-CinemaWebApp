﻿using CinemaApplicationWEB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaApplicationWEB.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }
}
