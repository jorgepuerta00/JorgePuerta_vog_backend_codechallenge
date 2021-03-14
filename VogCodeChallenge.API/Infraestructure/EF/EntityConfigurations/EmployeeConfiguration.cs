namespace VogCodeChallenge.API.Infraestructure.EF.EntityConfigurations
{
    using System;
    using Domain.AggregatesModel.EmployeeAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> configuration)
        {
            configuration.HasKey(g => g.Id);

            configuration.Property(g => g.Id)
                .ValueGeneratedNever()
                .IsRequired();

            configuration.Property<Guid>("DepartmentId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("DepartmentId")
                .IsRequired(true);

            configuration.HasOne(c => c.Department)
                .WithMany()
                .HasForeignKey("DepartmentId");
        }
    }
}
