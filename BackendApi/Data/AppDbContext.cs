using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BackendApi.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Amenity> amenities { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Property> properties { get; set; }
        public DbSet<PropertyImage> propertyImages { get; set; }
        public DbSet<Review> reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole> role = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Host",
                    NormalizedName = "HOST"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                }

            };
            builder.Entity<IdentityRole>().HasData(role);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => 
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            }
    }
}