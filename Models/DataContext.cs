
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    

    public void AddMovie(Movie movie)
    {
        this.Movies.Add(movie);
        this.SaveChanges();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@configuration["DataContext:ConnectionString"]);
    }
   }
}
