using WebApplication1.Database;
using WebApplication1.entities;
using WebApplication1.Model;

namespace WebApplication1.Repositories;

public abstract class AbstractRepository<T>
{

    public AbstractRepository()
    {
        db = new DatabaseConf();
    }

    protected DatabaseConf db;

    public abstract T getById(ulong id);
    public abstract List<T> getAll();

    public abstract ulong create(T entity);

    public abstract void deleteById(ulong id);
    public abstract void delete(T entity);
}