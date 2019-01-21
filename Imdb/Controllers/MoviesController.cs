using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imdb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Imdb.Controllers
{
    public class MoviesController : Controller
    {
        List<Movies> customMovies = new List<Movies>()
        {
            new Movies(){ ID=15, Name="Titanic",Plot="10",YearOfRelease=DateTime.UtcNow.Date},
            new Movies(){ ID=14, Name="Avatar",Plot="1s1",YearOfRelease=DateTime.UtcNow.Date.AddDays(10)},
            new Movies(){ ID=13, Name="ABC",Plot="10s",YearOfRelease=DateTime.UtcNow.Date},
            new Movies(){ ID=12, Name="MNO",Plot="110",YearOfRelease=DateTime.UtcNow.Date},
        };
        public IActionResult Index()
        {
            var movieList = customMovies.OrderBy(x => x.Name).ToList();
            return this.View(movieList.ToList());
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Create(Movies movie)
        {
            return View("Create");
        }

        public ActionResult Edit(int id)
        {
            var movie = customMovies.Find(x => x.ID == id);
            if (movie == null)
            {
                throw new Exception();
            }
            return this.View(movie);
        }

        
    }
}