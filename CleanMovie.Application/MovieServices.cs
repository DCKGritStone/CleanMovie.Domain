using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository imovieRepository;

        public MovieServices (IMovieRepository imovieRepository)
        {
            this.imovieRepository = imovieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
             imovieRepository.CreateMovie(movie);

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = imovieRepository.GetAllMovies();

            return movies;
        }
    }
}
