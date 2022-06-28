using DAL.Repositories.Generic;
using DAL.UnitOfWork;
using Entities;

namespace DAL.Repositories;
public class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    public MovieRepository(DatabaseContext context) : base(context)
    {
    }
}