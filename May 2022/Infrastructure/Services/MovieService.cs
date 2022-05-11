﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Core.Contracts.Repositories;
using Application_Core.Contracts.Services;
using Infrastructure.Repositories;
using MovieShopMVC.Models;

namespace Infrastructure.Services
{
    public class MovieService: IMovieService
    {
        public List<MovieCardModel> GetTop30GrossingMovies()
        {
            //call the movierepository
            //get the entity class data and map them in to model class data
            var movieRepo = new MovieRepository();
            var movies = movieRepo.GetTop30GrossingMovies();
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