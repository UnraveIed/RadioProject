using Microsoft.EntityFrameworkCore;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioProject.DataAccess.Concrete.EntityFramework
{
    public class RadioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RadioDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Radio> Radios { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
