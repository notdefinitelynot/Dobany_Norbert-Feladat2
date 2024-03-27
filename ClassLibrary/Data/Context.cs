using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connMySql = "Server=127.0.0.1;User ID=root;Password=;Database=peopleDB;";
            optionsBuilder.UseMySql(connMySql, ServerVersion.AutoDetect(connMySql));

            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=peopleDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

