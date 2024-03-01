using BasicProjectStructure.Data.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectStructure.Data.Context
{
    internal class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Company> Companies { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=EXIACDB5\\SQLEXPRESS;Database=ToDoList;User Id=vampi;Password=123;TrustServerCertificate=true;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

        }
    }
}
