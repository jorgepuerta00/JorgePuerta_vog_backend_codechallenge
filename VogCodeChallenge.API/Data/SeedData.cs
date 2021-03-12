namespace VogCodeChallenge.API.Data
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Models;
    using Serilog;

    public class SeedData
    {
        public static readonly Guid COMPANY_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D1");
        public static readonly Guid DEPARTMENT1_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D2");
        public static readonly Guid DEPARTMENT2_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D6");
        public static readonly Guid EMPLOYEE1_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D3");
        public static readonly Guid EMPLOYEE2_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D8");
        public static readonly Guid EMPLOYEE3_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D7");
        public static readonly Guid EMPLOYEE4_ID = new Guid("545DE66E-19AC-47D2-57F6-08D8715337D9");

        public static void EnsureSeedData(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddLogging();

            services.AddDbContext<ChallengeDbContext>(options =>
               options.UseSqlServer(connectionString));

            using (var serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var context = scope.ServiceProvider.GetService<ChallengeDbContext>();

                    context.Database.EnsureCreated();

                    var company = context.Companies.Find(COMPANY_ID);
                    if (company == null)
                    {
                        context.Companies.Add(new Company() { Id = COMPANY_ID, Name = "Company Acme" });
                        context.SaveChanges();
                        Log.Debug("Company Acme was created");
                    }
                    else
                    {
                        Log.Debug("Company Acme Exist");
                    }

                    var deparment1 = context.Departments.Find(DEPARTMENT1_ID);
                    if (deparment1 == null)
                    {
                        var obj = new Department() { Id = DEPARTMENT1_ID, Name = "Deparment One", Address = "Medellin", CompanyId = COMPANY_ID };
                        context.Departments.Add(obj);
                        context.SaveChanges();
                        Log.Debug("Deparment One was created");
                    }
                    else
                    {
                        Log.Debug("Deparment One Exist");
                    }

                    var employee1 = context.Employees.Find(EMPLOYEE1_ID);
                    if (employee1 == null)
                    {
                        var obj = new Employee() { Id = EMPLOYEE1_ID, FirstName = "George", LastName = "Gates", JobTitle = "Senior Fullstack", ResidenceAddress = "Medellin", DepartmentId = DEPARTMENT1_ID };
                        context.Employees.Add(obj);
                        context.SaveChanges();
                        Log.Debug("employee 1 was created");
                    }
                    else
                    {
                        Log.Debug("employee 1 Exist");
                    }

                    var employee2 = context.Employees.Find(EMPLOYEE2_ID);
                    if (employee2 == null)
                    {
                        var obj = new Employee() { Id = EMPLOYEE2_ID, FirstName = "Dianne", LastName = "Gates", JobTitle = "Nurse", ResidenceAddress = "Medellin", DepartmentId = DEPARTMENT1_ID };
                        context.Employees.Add(obj);
                        context.SaveChanges();
                        Log.Debug("employee 2 was created");
                    }
                    else
                    {
                        Log.Debug("employee 2 Exist");
                    }

                    var deparment2 = context.Departments.Find(DEPARTMENT2_ID);
                    if (deparment2 == null)
                    {
                        var obj = new Department() { Id = DEPARTMENT2_ID, Name = "Deparment Two", Address = "Cali", CompanyId = COMPANY_ID };
                        context.Departments.Add(obj);
                        context.SaveChanges();
                        Log.Debug("Deparment Two was created");
                    }
                    else
                    {
                        Log.Debug("Deparment Two Exist");
                    }

                    var employee3 = context.Employees.Find(EMPLOYEE3_ID);
                    if (employee3 == null)
                    {
                        var obj = new Employee() { Id = EMPLOYEE3_ID, FirstName = "Homer", LastName = "Simpson", JobTitle = "Senior Fullstack", ResidenceAddress = "Cali", DepartmentId = DEPARTMENT2_ID };
                        context.Employees.Add(obj);
                        context.SaveChanges();
                        Log.Debug("employee 3 was created");
                    }
                    else
                    {
                        Log.Debug("employee 3 Exist");
                    }

                    var employee4 = context.Employees.Find(EMPLOYEE4_ID);
                    if (employee4 == null)
                    {
                        var obj = new Employee() { Id = EMPLOYEE4_ID, FirstName = "Joe", LastName = "Cock", JobTitle = "Nurse", ResidenceAddress = "Cali", DepartmentId = DEPARTMENT2_ID };
                        context.Employees.Add(obj);
                        context.SaveChanges();
                        Log.Debug("employee 4 was created");
                    }
                    else
                    {
                        Log.Debug("employee 4 Exist");
                    }
                }
            }
        }
    }
}
