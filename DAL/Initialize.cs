using DAL.Repositories;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public static class Initialize
{
    public static IServiceCollection AddDAL(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IUnitOfWork, DatabaseContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IMovieRepository, MovieRepository>();
        return services;
    }
}