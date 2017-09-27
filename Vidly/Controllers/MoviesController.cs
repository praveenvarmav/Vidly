﻿using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET: movies/Details/id
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        //GET: movies/Edit/id
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //GET: movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
;        }

        [Route("movies/released/{year:regex(\\d{4}):range( 2012, 2017)}/{month:regex(\\d{2}):range( 1, 12)}")]
        //GET: movies/ByReleaseDate
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
    }
}