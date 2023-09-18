using Microsoft.EntityFrameworkCore;
using MoviesWebAPI.Movies;

namespace MoviesWebAPI.Data
{
    public  class ApplicationDbContext : DbContext

    {
        public DbSet<Movie> Movies { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
