using Am.Infrastructure.IRepositories;
using Am.Infrastructure.IServices;
using Am.Repository.Ef.Repository;
using Am.Service.Services;

namespace Am.Api.Extensions
{
    public static class AppExtensions
    {
        public static IServiceCollection AddConfig(this IServiceCollection services)
        {
            #region Repository


            services.AddTransient<IWeatherRepository, WeatherRepository>();

            #endregion

            #region Service


            services.AddTransient<IWeatherService, WeatherService>();


            #endregion

            return services;
        }
        public static IServiceCollection AddAuthenticationConfig(this IServiceCollection services, ConfigurationManager configuration)
        {
            /* services.AddAuthentication(options =>
             {
                 options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                 options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                 options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
             })

             // Adding Jwt Bearer
             .AddJwtBearer(options =>
             {
                 options.SaveToken = true;
                 options.RequireHttpsMetadata = false;
                 options.TokenValidationParameters = new TokenValidationParameters()
                 {
                         ValidateIssuer = true,
                         ValidateAudience = true,
                         ValidateLifetime = true,
                         ValidateIssuerSigningKey = true,
                         ClockSkew = TimeSpan.Zero,

                         ValidAudience = configuration["JWT:ValidAudience"],
                         ValidIssuer = configuration["JWT:ValidIssuer"],
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                 };
             });*/

            return services;
        }

    }
}
