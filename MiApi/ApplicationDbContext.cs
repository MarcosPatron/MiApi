using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;
using System;

namespace MiApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cervezas> Cervezas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cervezas>().ToTable("CERVEZAS");
        }
    }
}

