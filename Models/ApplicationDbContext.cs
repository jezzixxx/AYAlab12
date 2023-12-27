using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AYAlab12.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Popularity> Popularity { get; set; }
    }
}
