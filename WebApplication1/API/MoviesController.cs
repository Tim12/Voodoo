﻿using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using MovieAngularJSApp.Models;

namespace MovieAngularJSApp.API
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            //var Session = HttpContext.Con

            return new List<Movie>
            {
                new Movie {Id = 1, Title = "Star Wars", Director = "Lucas"},
                new Movie {Id = 2, Title = "King Kong", Director = "Jackson"},
                new Movie {Id = 3, Title = "Memento", Director = "Nolan"}
            };
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

    }
}
