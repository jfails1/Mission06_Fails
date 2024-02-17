﻿using Microsoft.EntityFrameworkCore;

namespace Mission06_Fails.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options) 
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}