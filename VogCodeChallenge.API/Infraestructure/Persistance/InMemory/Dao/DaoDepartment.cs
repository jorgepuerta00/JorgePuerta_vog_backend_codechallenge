namespace VogCodeChallenge.API.Infraestructure.Persistance.InMemory.Dao
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.AggregatesModel.CompanyAggregate;
    using Domain.AggregatesModel.DepartmentAggregate;
    using Infraestructure.Persistance.InMemory.Context;
    using Microsoft.EntityFrameworkCore;

    public class DaoDepartment : IDao<Department>
    {
        private DbContextOptions<InMemoryDbContext> Options { get; }

        public DaoDepartment()
        {
            Options = new DbContextOptionsBuilder<InMemoryDbContext>()
               .UseInMemoryDatabase(databaseName: "InMemory")
               .Options;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            using (var context = new InMemoryDbContext(Options))
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
            using (var context = new InMemoryDbContext(Options))
            {
                return await context.Departments.ToListAsync();
            }
        }
    }
}
