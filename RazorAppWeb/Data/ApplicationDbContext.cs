using System;
using Microsoft.EntityFrameworkCore;
using RazorAppWeb.Model;

namespace RazorAppWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Creates the Category table
        public DbSet<Category> Categories { get; set; }
    }
}

