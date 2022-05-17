using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Entities;
using ApplicationCore.Entities;

namespace Application_Core.Contracts.Repositories
{
    public interface IMovieRepository: IRepository<Movie>
    {
        //
        List<Movie> GetTop30GrossingMovies();
    }
}
