using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_TestTask.Models;

namespace ASP.NET_MVC_TestTask.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {
            FilmContext context = new FilmContext();

            var joined = from film in context.Set<Film>()
                         join actor in context.Set<Actor>()
                         on film.Actors equals actor.Id
                         select new { film, actor };
          
            List<JoinedFilm> list = new List<JoinedFilm>();

            foreach (var u in joined)
            {
                list.Add(new JoinedFilm() { MovieName= u.film.MovieName,Genre=u.film.Genre,Actors=u.actor.ActorName });
            }
    
            ViewBag.Films = list;
            ViewData["List"] = list.ToArray();
            return View();
        }
       
    }
}