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
        private DbSet<T> DbSet { get => _dbContext.Set<T>(); }
        public Repository(MainAppDbContext dbContext) => _dbContext = dbContext;

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return DbSet.Where(filter).AsNoTracking().ToList();
        }

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await DbSet.Where(filter).AsNoTracking().ToListAsync();
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
                DbSet.OrderBy(selector).AsNoTracking().ToList() :
                DbSet.OrderByDescending(selector).AsNoTracking().ToList();
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
                await DbSet.OrderBy(selector).AsNoTracking().ToListAsync() :
                await DbSet.OrderByDescending(selector).AsNoTracking().ToListAsync();
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
                DbSet.Where(filter).OrderBy(selector).AsNoTracking().ToList() :
                DbSet.Where(filter).OrderByDescending(selector).AsNoTracking().ToList();
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
                await DbSet.Where(filter).OrderBy(selector).AsNoTracking().ToListAsync() :
                await DbSet.Where(filter).OrderByDescending(selector).AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Find
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T Find(Guid Id)
        {
            return DbSet.Find(Id);
        }

        /// <summary>
        /// Find Async
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(Guid Id)
        {
            return await DbSet.FindAsync(Id);
        }

        /// <summary>
        /// Get By Filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public T GetByFilter(Expression<Func<T, bool>> filter)
        {
            return DbSet.SingleOrDefault(filter);
        }

        /// <summary>
        /// Get By Filter Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await DbSet.SingleOrDefaultAsync(filter);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            DbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// CreateAsync
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task CreateAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            DbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return DbSet.Count();
        }

        /// <summary>
        /// Count Async
        /// </summary>
        /// <returns></returns>
        public async Task<int> CountAsync()
        {
            return await DbSet.CountAsync();
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public int Count(Expression<Func<T, bool>> filter)
        {
            return DbSet.Count(filter);
        }

        /// <summary>
        /// Count Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            return await DbSet.CountAsync(filter);
        }

        /// <summary>
        /// Any
        /// </summary>
        /// <returns></returns>
        public bool Any()
        {
            return DbSet.Any();
        }

        /// <summary>
        /// Any Async
        /// </summary>
        /// <returns></returns>
        public async Task<bool> AnyAsync()
        {
            return await DbSet.AnyAsync();
        }

        /// <summary>
        /// Any
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool Any(Expression<Func<T, bool>> filter)
        {
            return DbSet.Any(filter);
        }

        /// <summary>
        /// Any Async
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await DbSet.AnyAsync(filter);
        }

        /// <summary>
        /// Get Query
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetQuery()
        {
            return DbSet.AsQueryable();
        }

        /// <summary>
        /// To Query String
        /// </summary>
        /// <returns></returns>
        public string ToQueryString()
        {
            return DbSet.ToQueryString();
        }
    }
}
