using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.Models.Response;
using MovieShop.Core.RepositoryInterfaces;
using MovieShop.Core.ServiceInterfaces;

namespace MovieShop.Infrastructure.Services
{
    public class CastService : ICastService
    {
        public async Task<CastDetailsResponseModel> GetCastDetailsWithMovies(int id)
        {
            throw new NotImplementedException();
        }
    }
}
