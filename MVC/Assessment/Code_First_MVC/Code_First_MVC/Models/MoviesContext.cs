
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Code_First_MVC.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("connectstr")
        { }

        public DbSet<Movies> Movie { get; set; }
    }
}
