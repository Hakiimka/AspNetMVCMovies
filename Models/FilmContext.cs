using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASP.NET_MVC_TestTask.Models
{
    public class FilmContext :DbContext
    {
        public FilmContext() : base("DbConnectionString")
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }

    }
}