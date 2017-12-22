using Microsoft.EntityFrameworkCore;
using QL.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL.Data.EntityFramework
{
    public class QLContext : DbContext
    {
        public QLContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Droid> Droids { get; set; }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Droid>().ToTable("Course");
            modelBuilder.Entity<Droid>().HasKey("Id");
            modelBuilder.Entity<Droid>().Property(e => e.Id).ValueGeneratedNever();

            modelBuilder.Entity<Friend>().HasKey("Id");
            modelBuilder.Entity<Friend>().Property(e => e.Id).ValueGeneratedNever();

            modelBuilder.Entity<Friend>().HasOne(x => x.Droid).WithMany(x => x.Friends);
            //modelBuilder.Entity<Droid>().HasMany(e => e.Friends).WithOne(j => j.Droids);
        }
    }
}
