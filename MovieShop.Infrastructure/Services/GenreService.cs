using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.Entities;
using MovieShop.Core.ServiceInterfaces;

namespace MovieShop.Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        public Task<IEnumerable<Genre>> GetAllGenres()
        {
            throw new NotImplementedException();
        }
    }
}
