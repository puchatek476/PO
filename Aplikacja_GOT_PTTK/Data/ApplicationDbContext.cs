using Aplikacja_GOT_PTTK.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikacja_GOT_PTTK.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<GeoPointModel> GeoPointModel { get; set; }
        public DbSet<PathModel> PathModel { get; set; }
        public DbSet<AccountModel> AccountModel { get; set; }
    }

}
