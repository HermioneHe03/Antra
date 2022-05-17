using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Contracts.Repositories;
using Application_Core.Entities;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }
        public List<Movie> GetTop30GrossingMovies()
        {
            // SQL Database
            // data access logic
            // ADO.NET (Microsoft) SQL Connection, SQLCommand
            // Dapper (ORM) -> StackOverflow
            // Entity Framework Core => LINQ
            // SELECT top 30 * FROM Movie order by Revenue
            // movies.orderbydescnding(m=> m.Revenue).Take(30)
            var movies = _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToList();
            return movies;
        }

        public override Movie GetById(int id)
        {
            // we need to join Navigation properties
            // Include method in EF will enable us to join with related navigation properties
            var movie = _dbContext.Movies.Include(m => m.MoviesOfGenre).ThenInclude(m => m.Genre)
                .Include(m =>m.MovieCasts).ThenInclude(m =>m.Cast)
                .Include(m => m.Trailers)
                .FirstOrDefault(m => m.Id == id);
            //FirstOrDefault safest one
            //First throws ex when 0 records
            //SingleOrDefault good for 0 or 1
            //Single throw ex when no records found or when more than 1 records found

            return movie;

        }
    }
}
