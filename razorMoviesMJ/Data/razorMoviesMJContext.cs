#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorMoviesMJ.Models;

namespace razorMoviesMJ.Data
{
    public class razorMoviesMJContext : DbContext
    {
        public razorMoviesMJContext (DbContextOptions<razorMoviesMJContext> options)
            : base(options)
        {
        }

        public DbSet<razorMoviesMJ.Models.Movie> Movie { get; set; }
    }
}
