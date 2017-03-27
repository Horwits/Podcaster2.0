using System.Linq;

namespace Podcaster.Data.Repositories.Contracts
{
    public interface IRepository<T>
        where T : class
    {
        void Add(T entity);

        IQueryable<T> All();

        void Delete(T entity);

        void Delete(object id);

        void Detach(T entity);

        T GetById(object id);

        T GetByName(string name);

        void Update(T entity);
    }
}