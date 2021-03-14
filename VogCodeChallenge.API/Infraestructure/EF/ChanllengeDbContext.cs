namespace VogCodeChallenge.API.Infraestructure.EF
{
    using Domain.AggregatesModel.CompanyAggregate;
    using Domain.AggregatesModel.DepartmentAggregate;
    using Domain.AggregatesModel.EmployeeAggregate;
    using EntityConfigurations;
    using Microsoft.EntityFrameworkCore;

    public class ChallengeDbContext : DbContext
    {
        public ChallengeDbContext(DbContextOptions<ChallengeDbContext> options)
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
