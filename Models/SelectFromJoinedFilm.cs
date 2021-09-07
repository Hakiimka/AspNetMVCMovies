using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_TestTask.Models
{
    public static class SelectFromJoinedFilm
    {
        public static List<JoinedFilm> SelectByMovieName(List<JoinedFilm> list,string moviename)
        {
            var selected = from i in list where i.MovieName == moviename select i;
            return new List<JoinedFilm>(selected);
        }
        public static List<JoinedFilm> SelectByGenre(List<JoinedFilm> list, string genre)
        {
            var selected = from i in list where i.Genre == genre select i;
            return new List<JoinedFilm>(selected);
        }
        public static List<JoinedFilm> SelectByActorName(List<JoinedFilm> list, string actorname)
        {
            var selected = from i in list where i.Actors == actorname select i;
            return new List<JoinedFilm>(selected);
        }
    }
}