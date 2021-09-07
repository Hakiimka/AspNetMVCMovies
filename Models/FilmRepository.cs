using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_TestTask.Models
{
    public class FilmRepository
    {
        private FilmContext context;
        public FilmRepository()
        {
            context = new FilmContext();
        }
        public List<Film> GetFilmsList()
        {
            return context.Films.ToList();
        }    

        public void InsertFilm(Film film)
        {
            context.Films.Add(film);
            context.SaveChanges();
        }
        public List<Film> SelectFilmsByMovieName(string name)
        { 
           var sorted = from i in context.Films.ToList() where i.MovieName == name select i;
           return new List<Film>(sorted);
        }
        public List<Film> SelectFilmsByGenre(string genre)
        {
            var sorted = from i in context.Films.ToList() where i.Genre == genre select i;
            return new List<Film>(sorted);
        }
    }
}