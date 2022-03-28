using MoviesApi1.Models;
using MoviesApi1.Models.DTOs.Responses;
using System.Collections.Generic;

namespace MoviesApi1.Services
{
    public interface IMovieService
    {
        List<MovieData> GetMoviesList();
        MovieData GetMovieDetailsById(int movieId);
        ResponseModel AddMovie(MovieData movie);
        ResponseModel DeleteMovie(int movieId);

    }
}
