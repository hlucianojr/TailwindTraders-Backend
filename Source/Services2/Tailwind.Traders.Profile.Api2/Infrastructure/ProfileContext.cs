﻿using Microsoft.EntityFrameworkCore;
using Tailwind.Traders.Profile.Api2.Models;

namespace Tailwind.Traders.Profile.Api2.Infrastructure
{
    public class ProfileContext : DbContext
    {
        public DbSet<Profiles> Profiles { get; set; }

        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profiles>()
                .HasAlternateKey(c => c.Email);
        }        
    }
}
