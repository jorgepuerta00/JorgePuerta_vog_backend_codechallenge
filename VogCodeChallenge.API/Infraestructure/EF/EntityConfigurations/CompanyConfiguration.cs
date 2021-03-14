namespace VogCodeChallenge.API.Infraestructure.EF.EntityConfigurations
{
    using Domain.AggregatesModel.CompanyAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> configuration)
        {
            configuration.HasKey(g => g.Id);

            configuration.Property(g => g.Id)
                .ValueGeneratedNever()
                .IsRequired();
        }
    }
}
