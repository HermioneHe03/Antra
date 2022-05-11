using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Contracts.Repositories;
using Application_Core.Entities;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetTop30GrossingMovies()
        {
            // SQL Database
            // data access logic
            // ADO.NET (Microsoft) SQL Connection, SQLCommand
            // Dapper (ORM) -> StackOverflow
            // Entity Framework Core => LINQ
            // SELECT top 30 * FROM Movie order by Revenue
            // movies.orderbydescnding(m=> m.Revenue).Take(30)
            throw new NotImplementedException();
        }
    }
}
