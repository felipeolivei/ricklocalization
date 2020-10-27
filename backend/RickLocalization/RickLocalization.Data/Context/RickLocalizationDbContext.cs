using Microsoft.EntityFrameworkCore;
using RickLocalization.Data.Seed;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Context
{
    public class RickLocalizationDbContext : DbContext
    {
        public DbSet<Dimension> Dimension { get; set; }
        public DbSet<BrowsingHistory> BrowsingHistory { get; set; }

        public RickLocalizationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrowsingHistory>()
                        .HasOne(b => b.DimensionFrom)
                        .WithMany(d => d.BrowsingHistoriesFrom)
                        .HasForeignKey(b => b.DimensionFromId)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<BrowsingHistory>()
                        .HasOne(b => b.DimensionTo)
                        .WithMany(d => d.BrowsingHistoriesTo)
                        .HasForeignKey(b => b.DimensionToId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new DimensionConfiguration());
        }

    }
}
