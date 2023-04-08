using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Manage.Model
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=127.0.0.1;Database=myo1db;User=root;Password=213316;");
        }
        public DbSet<Blog> Blog { get; set; }
      //  public DbSet<User> User { get; set; }
    }
}