namespace VogCodeChallenge.API.Infraestructure.Persistance.SqlServer.Context
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.AggregatesModel.CompanyAggregate;
    using Domain.AggregatesModel.DepartmentAggregate;
    using Microsoft.EntityFrameworkCore;

    public class DaoDepartment : IDao<Department>
    {
        private DbContextOptions<SqlServerDbContext> Options { get; }

        public DaoDepartment()
        {
            Options = new DbContextOptionsBuilder<SqlServerDbContext>()
               .UseInMemoryDatabase(databaseName: "SqlServer")
               .Options;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            using (var context = new SqlServerDbContext(Options))
            {
                var company = new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "Simpson Company"
                };

                context.Companies.Add(company);
                context.SaveChanges();

                var department = new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Deparment Three",
                    Address = "Medellin",
                    CompanyId = company.Id
                };

                context.Departments.Add(department);
                context.SaveChanges();

                return await context.Departments.ToListAsync();
            }
        }

        public async Task<IList<Department>> ListAll()
        {
            using (var context = new SqlServerDbContext(Options))
            {
                return await context.Departments.ToListAsync();
            }
        }
    }
}
