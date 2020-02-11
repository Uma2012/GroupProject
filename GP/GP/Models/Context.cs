using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GroupProject;Trusted_Connection=True;");
    }
}
