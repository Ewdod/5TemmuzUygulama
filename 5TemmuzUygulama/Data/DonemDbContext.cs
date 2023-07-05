using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Xml;
namespace _5TemmuzUygulama.Data
{

    public class DonemDbContext : DbContext
    {
        public DbSet<Donem> Donemler => Set<Donem>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\EWDOD;Database=DonemDatabase; uid=sa;pwd=1309");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Donem>().ToTable("Semesters")
        .HasOne(d => d.TotalMoney)
        .WithOne(t => t.Donem)
        .HasForeignKey<Donem>(d => d.ParaBaglantisi);
        }
    }
}
