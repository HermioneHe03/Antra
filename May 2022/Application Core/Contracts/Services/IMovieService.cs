using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Contracts.Repositories;
using Application_Core.Models;

namespace Application_Core.Contracts.Services
{
    public interface IMovieService
    {
       //home/index action method
        List<MovieCardModel> GetTop30GrossingMovies();

        MovieDetailsModel GetMovieDetails(int movieId);
    }
}
