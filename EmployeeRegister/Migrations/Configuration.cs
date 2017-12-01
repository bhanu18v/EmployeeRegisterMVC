namespace EmployeeRegister.Migrations
{
    using EmployeeRegister.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            

        context.Employees.AddOrUpdate(n => n.FirstName, new Employee()
            {
            FirstName = "Bhanu",
            LastName="Vakamalla",
            Salary=10000,
            Position="Developer",
            Department="IT"

            });
            context.Employees.AddOrUpdate(n => n.FirstName, new Employee()
            {
                FirstName = "Sai",
                LastName = "Bodimallu",
                Salary = 20000,
                Position = "Manager",
                Department = "Sales"

            });
            context.Employees.AddOrUpdate(n => n.FirstName, new Employee()
            {
                FirstName = "Varnica",
                LastName = "Bodimallu",
                Salary = 25000,
                Position = "Senior Manager",
                Department = "Computer"

            }, new Employee()
            {
                FirstName = "Honey",
                LastName = "Katam",
                Salary = 2000,
                Position = "Senior sales Manager",
                Department = "SDM"

            });
            context.EmpIds.AddOrUpdate(n => n.IdNumber, new EmpId()
            {
                IdNumber = 123,
              Country="India"
            });




        }
    }
}
