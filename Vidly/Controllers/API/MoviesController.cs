using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using AutoMapper;
using Vidly.Dtos;

namespace Vidly.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext(); 
        }

        //get ~/Movie
        public IEnumerable<MovieDtos> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDtos>);
        }
        //get ~/Movie/id
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return Ok(Mapper.Map<Movie, MovieDtos>(movie));
        }
    //Post 
    [HttpPost]
        public IHttpActionResult CreateMovie(MovieDtos movieDto)
        {
            if (!ModelState.IsValid)
            
                return BadRequest();
        var movie =Mapper.Map<MovieDtos, Movie>(movieDto);
           _context.Movies.Add( movie);
           _context.SaveChanges();
        movieDto.Id=movie.Id;
        return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }
        [HttpPut]
        public void UpdateMovie(int id ,MovieDtos movieDto )
        {  
        var MovieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
        if (!ModelState.IsValid)
            throw new HttpResponseException(HttpStatusCode.BadRequest);
        if (MovieInDb == null)
            throw new HttpResponseException(HttpStatusCode.NotFound);
        Mapper.Map(movieDto, MovieInDb);
        
        }
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
           
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Movies.Remove(movie);
            _context.SaveChanges();

        }
    }
}
