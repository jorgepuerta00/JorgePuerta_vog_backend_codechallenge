namespace VogCodeChallenge.API.Infraestructure.Persistance.SqlServer.Context
{
    using Domain.AggregatesModel.CompanyAggregate;
    using Domain.AggregatesModel.DepartmentAggregate;
    using Domain.AggregatesModel.EmployeeAggregate;
    using Infraestructure.EF.EntityConfigurations;
    using Microsoft.EntityFrameworkCore;

    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CompanyConfiguration());
            builder.ApplyConfiguration(new DeparmentConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
