using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Contracts.Repositories;
using Application_Core.Contracts.Services;
using Infrastructure.Repositories;
using Application_Core.Models;

namespace Infrastructure.Services
{
    public class MovieService: IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public MovieDetailsModel GetMovieDetails(int movieId)
        {
            var movie = _movieRepository.GetById(movieId);
            var movieDetails = new MovieDetailsModel
            {
                Id = movie.Id,
                Budget = movie.Budget,
            };
            foreach (var trailer in movie.Trailers)
            {
                movieDetails.Trailers.Add ( new TrailerModel { Id = trailer.Id, Name = trailer.Name, TrailerUrl = trailer.TrailerUrl})
            }
            foreach (var genre in movie.MoviesOfGenre)
            {
                movieDetails.Genres.Add( new GenreModel { Id = genre.GenreId, Name = genre.Genre.Name})

            }

        }
        public List<MovieCardModel> GetTop30GrossingMovies()
        {
            //call the movierepository
            //get the entity class data and map them in to model class data
            // var movieRepo = new MovieRepository();
            //var movies = movieRepo.GetTop30GrossingMovies();
            var movies = _movieRepository.GetTop30GrossingMovies();

            var movieCards = new List<MovieCardModel>();
            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardModel
                {
                    Id = movie.Id,
                    PosterUrl = movie.PosterUrl,
                    Title = movie.Title
                });
            }
            return movieCards;
        }
    }
}
