using MainApp.Application.Enums;
using MainApp.Domain.Common;
using System.Linq.Expressions;

namespace MainApp.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        List<T> GetAll(Expression<Func<T, bool>> filter);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        List<T> GetAll<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);
        List<T> GetAll<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);
        T Find(Guid Id);
        Task<T> FindAsync(Guid Id);
        T GetByFilter(Expression<Func<T, bool>> filter);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
        void Create(T entity);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
        int Count();
        Task<int> CountAsync();
        int Count(Expression<Func<T, bool>> filter);
        Task<int> CountAsync(Expression<Func<T, bool>> filter);
        bool Any();
        Task<bool> AnyAsync();
        bool Any(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        IQueryable<T> GetQuery();
        string ToQueryString();
    }
}
