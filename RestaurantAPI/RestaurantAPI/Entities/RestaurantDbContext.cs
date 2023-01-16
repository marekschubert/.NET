﻿using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.Entities
{
    public class RestaurantDbContext : DbContext
    {
        private string _connectionString = "Server=MAREK\\SQLEXPRESS; Database=RestaurantDb;Encrypt=False;  Trusted_Connection=True";

        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Address> Addresses{ get; set;}
        public DbSet<Dish> Dishes { get; set;}

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Name)
               // .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Dish>()
                .Property(d => d.Name);
            // .IsRequired(); 

            modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .HasMaxLength(50);
            //  .IsRequired(true);

            modelBuilder.Entity<Address>()
                .Property(a => a.Street);
               // .IsRequired(true);
               // .HasMaxLength(50);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
