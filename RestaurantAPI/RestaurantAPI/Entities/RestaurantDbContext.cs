﻿using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.Entities
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Address> Addresses{ get; set;}
        public DbSet<Dish> Dishes { get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }


        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Dish>()
                .Property(d => d.Name)
                .IsRequired(); 

            modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .HasMaxLength(50)
                .IsRequired(true);

            modelBuilder.Entity<Address>()
                .Property(a => a.Street)
                .IsRequired(true)
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(a => a.Email)
                .IsRequired();

            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired();
        }

    }
}
