using Microsoft.EntityFrameworkCore;
using mvcapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapp.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}
