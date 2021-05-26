using Lab5_6.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_6.Services
{
    public class IdentityContext : IdentityDbContext<User>
    {
        public DbSet<Post> Posts { get; set; }
        public IdentityContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Post>().ToTable("Posts");
        }
    }
}
