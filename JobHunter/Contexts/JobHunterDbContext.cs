﻿using JobHunter.Common;
using JobHunter.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.Contexts
{
    public class JobHunterDbContext : DbContext
    {
        public DbSet<JobPost> JobPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.151.83.102;Port=5432;Database=JobHunterSeyma;User Id=yunusemresenteam;Password=3*ZM44j3bgIBULDrlsyjKB595;");
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    ((ICreatedByEntity)entry.Entity).CreatedOn = DateTime.UtcNow;

                if (entry.State == EntityState.Modified)
                    ((IModifiedByEntity)entry.Entity).ModifiedOn = DateTime.UtcNow;

            }

            return base.SaveChanges();
        }
    }
}