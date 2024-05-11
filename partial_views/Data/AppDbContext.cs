using System;
using partial_views.Models;
using Microsoft.EntityFrameworkCore;
namespace partial_views.Data
    
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}

