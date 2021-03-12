namespace VogCodeChallenge.API.Data.EntityConfigurations
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

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
