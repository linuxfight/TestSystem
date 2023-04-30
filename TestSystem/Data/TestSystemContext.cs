using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestSystem.Models;

namespace TestSystem.Data
{
    public class TestSystemContext : DbContext
    {
        public DbSet<Question> Question { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var dbName = "testSystem.db";
            var fullPath = path + dbName;
            optionsBuilder.UseSqlite($"Data source={fullPath}");
        }
    }
}
