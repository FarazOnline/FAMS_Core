using FAMSWPF.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAMSWPF.Models.Sample
{
    public class FAMSContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder DBCOB)
        {
            if (!DBCOB.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory + "\\Settings")
                .AddJsonFile("FAMS.json")
                .Build();

                DBCOB.UseSqlServer(configuration.GetConnectionString("FAMSDBCNXN"));
            }
        }

        protected override void OnModelCreating(ModelBuilder MB)
        {
            MB.ApplyConfiguration(new FAMSConfig());
        }
    }
}