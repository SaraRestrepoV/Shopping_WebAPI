﻿using Microsoft.EntityFrameworkCore;
using ShoppingWebAPI.DAL.Entitiess;

namespace ShoppingWebAPI.DAL
{
    public class DataBaseContext : DbContext
    {   
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
                        
        }

        private DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
