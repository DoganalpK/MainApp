using MainApp.Application.Enums;
using MainApp.Application.Interfaces.Dtos;
using MainApp.Domain.Common;
using System.Linq.Expressions;

namespace MainApp.Application.Interfaces.Repositories
{
    public interface IRepository<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        List<ListDto> GetAll();
        Task<List<ListDto>> GetAllAsync();
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
