using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceHeroWebApi.Models;

namespace ServiceHeroWebApi.Data
{
    public class AdContext : DbContext
    {
        public AdContext(DbContextOptions<AdContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<JobAd> JobAds { get; set; }

    }
}
