using DAL.Repositories;
using DAL.UnitOfWork;
using Entities;

namespace BLL.Services;
public class MovieService : IMovieService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMovieRepository _movieRepository;

    public MovieService(IUnitOfWork unitOfWork, IMovieRepository movieRepository)
    {
        _unitOfWork = unitOfWork;
        _movieRepository = movieRepository;
    }

    public ICollection<Movie> GetList()
    {
        return _movieRepository.GetAll();
    }

    public void Add(Movie p_movie)
    {
        _movieRepository.Insert(p_movie);
        _unitOfWork.SaveChanges();
    }
}