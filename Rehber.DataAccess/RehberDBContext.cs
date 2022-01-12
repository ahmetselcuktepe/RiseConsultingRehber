using Microsoft.EntityFrameworkCore;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Rehber.DataAccess
{
    public class RehberDBContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=RehberDB;Trusted_Connection=True;");
        }

        public DbSet<RehberK> RehberKs { get; set; }
        public DbSet<RehberKDetail> RehberKDetails { get; set; }
    }
}
