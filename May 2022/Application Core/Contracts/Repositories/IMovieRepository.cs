using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Entities;
using Application_Core.Models;
using ApplicationCore.Entities;

namespace Application_Core.Contracts.Repositories
{
    public interface IMovieRepository: IRepository<Movie>
    {
        //
        Task<List<Movie>> GetTop30GrossingMovies();
        //totalcount, pagesize, pageNumber
        //Task<(List<Movie>, int totalCount, int totalPages)> GetMoviesByGenres(int genreId, int pageSize = 30, int pageNumber = 1);
        Task<PagedResultSet<Movie>> MoviesByGenre(int genreId, int pageSize = 30, int pageNumber = 1);
    }
}
