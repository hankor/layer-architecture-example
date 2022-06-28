using Entities;

namespace BLL.Services;

public interface IMovieService
{
    ICollection<Movie> GetList();
    void Add(Movie movie);
}