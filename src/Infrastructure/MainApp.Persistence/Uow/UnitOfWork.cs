using MainApp.Application.Interfaces.Repositories;
using MainApp.Application.Interfaces.Uow;
using MainApp.Domain.Common;
using MainApp.Persistence.Contexts;
using MainApp.Persistence.Repositories;

namespace MainApp.Persistence.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainAppDbContext _context;

        public UnitOfWork(MainAppDbContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity => new Repository<T>(_context);

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
