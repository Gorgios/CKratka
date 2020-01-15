using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkijumpingTeams.Models;

namespace SkijumpingTeams.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SkijumpingTeams.Models.Team> Teams { get; set; }
        public DbSet<SkijumpingTeams.Models.Coach> Coaches { get; set; }
        public DbSet<SkijumpingTeams.Models.Jumper> Jumpers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Jumper>()
                .HasOne(p => p.Team)
                .WithMany(b => b.Jumpers)
                .HasForeignKey(p => p.TeamID);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coach>()
                .HasOne(p => p.Team)
                .WithMany(b => b.Coaches)
                .HasForeignKey(p => p.TeamID);

        }
    }
}
