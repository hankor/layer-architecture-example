using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.UnitOfWork;

public class DatabaseContext : DbContext, IUnitOfWork
{
    public virtual DbSet<Movie> Movies { get; set; }

    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
}