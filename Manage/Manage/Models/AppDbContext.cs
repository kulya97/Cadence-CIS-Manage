using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage.Models.Table;
namespace Manage.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<RES> res_db { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\Github\\Cadence-CIS-Manage\\Cadence_library.MDB;");
        }
    }
}