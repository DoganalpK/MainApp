using MainApp.Application.Interfaces.Repositories;
using MainApp.Domain.Common;

namespace MainApp.Application.Interfaces.Uow
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }
}
