using MainApp.Application.Interfaces.Dtos;
using MainApp.Application.Interfaces.Repositories;
using MainApp.Domain.Common;

namespace MainApp.Application.Interfaces.Services
{
    public interface IService<CreateDto, UpdateDto, ListDto, T> : IRepository<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {

    }
}
