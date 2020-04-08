using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Bidyo.Models;
using Bidyo.Dtos;

namespace Bidyo.Controllers.API
{
    public class MoviesController : ApiController
    {
        //context for database
        private ApplicationDbContext _context;

        //constructor
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/movies
        //return a list of movies
        public IHttpActionResult GetMovies()
        {
            var moviesDtos = _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);

            return Ok(moviesDtos);
        }

        //GET /api/movies/1
        //return a single movie record
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null) return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //POST /api/movies
        //add a movie
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movie);

            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        //PUT /api/movies/1
        //update a single movie record
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            //seach record in the db
            var movieInDb = _context.Movies.Single(m => m.Id == id);

            if (movieInDb == null) return NotFound();

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();

            return Ok();
        }

        //DELETE /api/movies/1
        //delete a movie
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            //check for the record in the db
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null) return NotFound();

            _context.Movies.Remove(movieInDb);

            _context.SaveChanges();

            return Ok();
        }

    }
}
