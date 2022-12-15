﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDatabaseDTO;

namespace MovieDatabaseRepository
{
    public class MovieRepository
    {
        private IConfigurationRoot _configuration;
        private DbContextOptionsBuilder<ApplicationDBContext> _optionsBuilder;

        public MovieRepository()
        {
            BuildOptions();
        }

        private void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MovieDatabase"));
        }
        //public List<Movie> GetAllMovies()
        //{
        //    using (ApplicationDBContext db = new ApplicationDBContext(_optionsBuilder.Options))
        //    {
        //        //return db.Movies.Include(x => x.Title).ToList();
        //        return db.Movies.Include(x => x.Title).Include(x => x.Genre).ToList();
        //    }
        //}
        public bool AddItem(Movie itemToAdd)
        {
            using (ApplicationDBContext db = new ApplicationDBContext(_optionsBuilder.Options))
            {
                //determine if item exists
                //Movie existingItem = db.Movies.FirstOrDefault(x => x.Title.ToLower() == itemToAdd.Title.ToLower());

                //if (existingItem == null)
                //{
                // doesn't exist, add it
                db.Movies.Add(itemToAdd);
                db.SaveChanges();
                return true;
                //}

                //return false;
            }
        }
    }
}
