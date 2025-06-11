using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Identity;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : IdentityDbContext<AppUser>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AV1UIG0; initial Catalog=ApiMovieDb; integrated Security=true;  TrustServerCertificate=Yes");
        }
        // veri tabanına yansıtacağımız tablolarımızı yazıyoruz

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
