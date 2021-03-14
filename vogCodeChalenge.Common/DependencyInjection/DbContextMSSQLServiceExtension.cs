namespace vogCodeChallenge.Common.DependencyInjection
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using VogCodeChallenge.Common.Configuration;

    public static class DbContextMSSQLServiceExtension
    {
        public static IServiceCollection AddCustomMSSQLDbContext<TDbContext>(this IServiceCollection services, IConfiguration configuration) where TDbContext : DbContext
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContextPool<TDbContext>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("MSSQL"),
                        sqlServerOptionsAction: sqlOptions =>
                        {
                            sqlOptions
                                .EnableRetryOnFailure(
                                    maxRetryCount: 15,
                                    maxRetryDelay: TimeSpan.FromSeconds(30),
                                    errorNumbersToAdd: null);
                        }
                    );
                },
                    10
                );

            services.AddSingleton(settings => {
                CommonGlobalAppSingleSettings commonGlobalAppSingleSettings = new CommonGlobalAppSingleSettings();
                commonGlobalAppSingleSettings.MssqlConnectionString = configuration.GetConnectionString("MSSQL");
                return commonGlobalAppSingleSettings;
            });

            return services;
        }
    }
}