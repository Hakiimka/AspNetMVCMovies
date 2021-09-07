using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_TestTask.Models
{
    public class ActorRepository
    {
        private FilmContext context;
        public ActorRepository()
        {
            context = new FilmContext();
        }
        public List<Actor> GetActorsList()
        {
            return new List<Actor>(context.Actors);
        }
        public List<Actor> SelectActorsById(int id)
        {
            var sorted = from i in context.Actors.ToList() where i.Id == id select i;
            return new List<Actor>(sorted);
        }
    }
}