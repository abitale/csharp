using MoviesApi1.Data;
using MoviesApi1.Models;
using MoviesApi1.Models.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesApi1.Services
{
    public class MovieService:IMovieService
    {
        private ApiDbContext _context;

        public MovieService(ApiDbContext context)
        {
            _context = context; 

        }

        public ResponseModel AddMovie(MovieData movie)
        {
            throw new NotImplementedException();
        }

        public ResponseModel DeleteMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public MovieData GetMovieDetailsById(int movieId)
        {
            throw new NotImplementedException();
        }

        public List<MovieData> GetMoviesList()
        {
            List<MovieData> movieList;
            try
            {
                movieList = _context.Set<MovieData>().ToList();
            }
            catch (Exception e)
            {
                throw;
            }

            return movieList;
        }
    }
}
