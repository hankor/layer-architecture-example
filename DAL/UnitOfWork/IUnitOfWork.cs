namespace DAL.UnitOfWork;

public interface IUnitOfWork
{
    int SaveChanges();
}