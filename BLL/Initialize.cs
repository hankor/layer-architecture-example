using BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BLL;

public static class Initialize
{
    public static IServiceCollection AddBLL(this IServiceCollection services)
    {
        return services.AddScoped<IMovieService, MovieService>();
    }
}