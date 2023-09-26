using MainApp.Application.Enums;
using MainApp.Application.Interfaces.Repositories;
using MainApp.Domain.Common;
using MainApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MainApp.Persistence.Repositories
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MainAppDbContext _dbContext;
        private DbSet<T> _dbSet { get => _dbContext.Set<T>(); }
        public Repository(MainAppDbContext dbContext) => _dbContext = dbContext;

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).AsNoTracking().ToList();
        }

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="selector"></param>
        /// <param name="orderByType"></param>
        /// <returns></returns>
        public List<T> GetAll<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC ?
                _dbSet.OrderBy(selector).AsNoTracking().ToList() :
                _dbSet.OrderByDescending(selector).AsNoTracking().ToList();
        }

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="selector"></param>
        /// <param name="orderByType"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC ?
                await _dbSet.OrderBy(selector).AsNoTracking().ToListAsync() :
                await _dbSet.OrderByDescending(selector).AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="filter"></param>
        /// <param name="selector"></param>
        /// <param name="orderByType"></param>
        /// <returns></returns>
        public List<T> GetAll<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC ?
                _dbSet.Where(filter).OrderBy(selector).AsNoTracking().ToList() :
                _dbSet.Where(filter).OrderByDescending(selector).AsNoTracking().ToList();
        }

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="filter"></param>
        /// <param name="selector"></param>
        /// <param name="orderByType"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC ?
                await _dbSet.Where(filter).OrderBy(selector).AsNoTracking().ToListAsync() :
                await _dbSet.Where(filter).OrderByDescending(selector).AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Find
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T Find(Guid Id)
        {
            return _dbSet.Find(Id);
        }

        /// <summary>
        /// Find Async
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(Guid Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        /// <summary>
        /// Get By Filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public T GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        /// <summary>
        /// Get By Filter Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.SingleOrDefaultAsync(filter);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _dbSet.Count();
        }

        /// <summary>
        /// Count Async
        /// </summary>
        /// <returns></returns>
        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public int Count(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Count(filter);
        }

        /// <summary>
        /// Count Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.CountAsync(filter);
        }

        /// <summary>
        /// Any
        /// </summary>
        /// <returns></returns>
        public bool Any()
        {
            return _dbSet.Any();
        }

        /// <summary>
        /// Any Async
        /// </summary>
        /// <returns></returns>
        public async Task<bool> AnyAsync()
        {
            return await _dbSet.AnyAsync();
        }

        /// <summary>
        /// Any
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool Any(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        /// <summary>
        /// Any Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AnyAsync(filter);
        }

        /// <summary>
        /// Get Query
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        /// <summary>
        /// To Query String
        /// </summary>
        /// <returns></returns>
        public string ToQueryString()
        {
            return _dbSet.ToQueryString();
        }
    }
}
