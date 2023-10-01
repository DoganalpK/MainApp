using MainApp.Application.Interfaces.Dtos;
using MainApp.Application.Wrappers;
using MainApp.Domain.Common;

namespace MainApp.Application.Interfaces.Services
{
    public interface IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<IDto>> FindAsync(Guid id);
        Task<IResponse<List<ListDto>>> GetAllAsync();
    }
}
