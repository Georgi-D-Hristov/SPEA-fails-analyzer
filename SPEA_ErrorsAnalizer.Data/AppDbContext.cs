using Microsoft.EntityFrameworkCore;
using SPEA_ErrorsAnalizer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEA_ErrorsAnalizer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TestReport> TestReports { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
        public DbSet<TestEntry> TestEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TestReportDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestReport>()
                .HasMany(tr => tr.SerialNumbers)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TestReport>()
                .HasMany(tr => tr.TestEntries)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
