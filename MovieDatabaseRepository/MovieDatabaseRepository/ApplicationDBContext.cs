﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieDatabaseDTO;

namespace MovieDatabaseRepository
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDBContext()
        {

        }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        private static IConfigurationRoot _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                string cnstr = _configuration.GetConnectionString("MovieDatabase");

                optionsBuilder.UseSqlServer(cnstr);
            }
        }
    }
}