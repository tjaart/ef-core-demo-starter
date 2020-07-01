using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkDemo
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }
        public DbSet<DepartmentManagerEntity> DepartmentManagers { get; set; }
        
        public static readonly Microsoft.Extensions.Logging.LoggerFactory _myLoggerFactory = 
            new LoggerFactory(new[] { 
                new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider() 
            });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
            optionsBuilder.UseSqlite("Filename=employees.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}