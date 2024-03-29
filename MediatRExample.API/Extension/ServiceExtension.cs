using MediatRExample.API.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MediatRExample.API.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(configuration["ConnectionStrings:conection"]);
            });
            services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
