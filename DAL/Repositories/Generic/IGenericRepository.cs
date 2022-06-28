namespace DAL.Repositories.Generic;

public interface IGenericRepository<T> where T : class
{
    IList<T> GetAll();
    void Insert(T entity);
}