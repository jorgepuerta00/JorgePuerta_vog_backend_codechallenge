namespace VogCodeChallenge.API.Infraestructure.EF.EntityConfigurations
{
    using System;
    using Domain.AggregatesModel.DepartmentAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DeparmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> configuration)
        {
            configuration.HasKey(g => g.Id);

            configuration.Property(g => g.Id)
                .ValueGeneratedNever()
                .IsRequired();

            configuration.Property<Guid>("CompanyId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CompanyId")
                .IsRequired(true);

            configuration.HasOne(c => c.Company)
                .WithMany()
                .HasForeignKey("CompanyId");
        }
    }
}
