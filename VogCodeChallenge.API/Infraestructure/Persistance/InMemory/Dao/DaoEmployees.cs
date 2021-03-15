namespace VogCodeChallenge.API.Infraestructure.Persistance.InMemory.Dao
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.AggregatesModel.EmployeeAggregate;
    using Infraestructure.Persistance.InMemory.Context;
    using Microsoft.EntityFrameworkCore;

    public class DaoEmployees : IDao<Employee>
    {
        private DbContextOptions<InMemoryDbContext> Options { get; }

        public DaoEmployees()
        {
            Options = new DbContextOptionsBuilder<InMemoryDbContext>()
               .UseInMemoryDatabase(databaseName: "InMemory")
               .Options;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            using (var context = new InMemoryDbContext(Options))
            {
                return await context.Employees.ToListAsync();
            }
        }

        public async Task<IList<Employee>> ListAll()
        {
            using (var context = new InMemoryDbContext(Options))
            {
                return await context.Employees.ToListAsync();
            }
        }
    }
}
