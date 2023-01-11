using API.Data;
using API.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {

          public static IServiceCollection AddApplicationServices(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration config)
  
  {

         services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
    
                services.AddDbContext<DataContext>(options => 
                 {  options.UseSqlServer(config.GetConnectionString("DefaultConnection"));    });
                              return services;

  }
        
    }
}