using System;
using EntityFrameworkDemo.Entities;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== WELCOME TO EMP DB ==");

            var empDb = new EmployeeDbContext();

            empDb.Database.EnsureCreated();

            var dept = new DepartmentEntity
            {
                DepartmentName = "Human Resources"
            };

            empDb.Departments.Add(dept);
            
            empDb.SaveChanges();
        }

    }
}