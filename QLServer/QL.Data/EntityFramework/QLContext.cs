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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Droid>().ToTable("Course");
        //}
    }
}
