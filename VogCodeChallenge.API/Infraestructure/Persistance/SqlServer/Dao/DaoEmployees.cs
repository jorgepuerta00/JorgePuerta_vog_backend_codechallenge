namespace VogCodeChallenge.API.Infraestructure.Persistance.SqlServer.Context
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.AggregatesModel.EmployeeAggregate;
    using Microsoft.EntityFrameworkCore;

    public class DaoEmployees : IDao<Employee>
    {
        private DbContextOptions<SqlServerDbContext> Options { get; }

        public DaoEmployees()
        {
            Options = new DbContextOptionsBuilder<SqlServerDbContext>()
               .UseInMemoryDatabase(databaseName: "SqlServer")
               .Options;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            using (var context = new SqlServerDbContext(Options))
            {
                return await context.Employees.ToListAsync();
            }
        }

        public async Task<IList<Employee>> ListAll()
        {
            using (var context = new SqlServerDbContext(Options))
            {
                return await context.Employees.ToListAsync();
            }
        }
    }
}
