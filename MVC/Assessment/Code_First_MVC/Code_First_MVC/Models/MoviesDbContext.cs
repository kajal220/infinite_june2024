using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Code_First_MVC.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(): base("MoviesDb")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}