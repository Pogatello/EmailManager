using AutoMapper;
using EmailManager.Contract;
using EmailManager.Infrastructure;
using EmailManager.Model;
using EmailManager.Repository;
using EmailManager.Service;
using EmailManager.Service.Mapper;
using Microsoft.EntityFrameworkCore;

namespace EmailManager.Web
{
    public static class DiContainer
    {
        #region Public Methods

        public static void Configure(WebApplicationBuilder builder)
        {
            ConfigureServices(builder.Services);
            ConfigureRepositories(builder.Services, builder.Configuration);
            ConfigureDatabase(builder.Services, builder.Configuration);
            ConfigureMappingProfiles(builder.Services);
        }

        #endregion


        #region Private Methods

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IEmailService, EmailService>();
        }

        private static void ConfigureRepositories(IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IEmailRepository, EmailRepository>();
        }

        private static void ConfigureDatabase(IServiceCollection services, IConfiguration config)
        {
            var databaseConfig = config.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();

            services.AddDbContext<AppDbContext>(
                (options) => options.UseSqlServer(databaseConfig.ConnectionString),
                ServiceLifetime.Scoped
            );
        }

        public static void ConfigureMappingProfiles(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EmailMappingProfile());
            });

            services.AddSingleton(mapperConfig.CreateMapper());
        }

        #endregion
    }
}
