using AutoMapper;
using FluentValidation;
using MainApp.Application.Enums;
using MainApp.Application.Interfaces.Dtos;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Application.Wrappers;
using MainApp.Domain.Common;
using MainApp.Persistence.Wrappers;

namespace MainApp.Application.Services
{
    public class Service<CreateDto, UpdateDto, ListDto, T> : IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        private readonly IUnitOfWork _uow;
        private readonly IValidator<CreateDto> _createValidator;
        //private readonly IValidator<UpdateDto> _updateValidator;
        private readonly IMapper _mapper;

        //public Service(IUnitOfWork uow, IValidator<CreateDto> createValidator, IValidator<UpdateDto> updateValidator, IMapper mapper)
        //{
        //    _uow = uow;
        //    _createValidator = createValidator;
        //    _updateValidator = updateValidator;
        //    _mapper = mapper;
        //}

        public Service(IUnitOfWork uow, IValidator<CreateDto> createValidator, IMapper mapper)
        {
            _uow = uow;
            _createValidator = createValidator;
            _mapper = mapper;
        }

        public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            var validationResult = _createValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                T createdEntity = _mapper.Map<T>(dto);
                await _uow.GetRepository<T>().CreateAsync(createdEntity);
                return new Response<CreateDto>(ResponseType.Success, dto);
            }
            return new Response<CreateDto>(dto, new());
            throw new NotImplementedException();
        }

        public async Task<IResponse<IDto>> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResponse<List<ListDto>>> GetAllAsync()
        {
            var data = await _uow.GetRepository<T>().GetAllAsync();
            var dto = _mapper.Map<List<ListDto>>(data);
            return new Response<List<ListDto>>(ResponseType.Success, dto);
        }

        Task<IResponse<CreateDto>> IService<CreateDto, UpdateDto, ListDto, T>.CreateAsync(CreateDto dto)
        {
            throw new NotImplementedException();
        }

        Task<IResponse<IDto>> IService<CreateDto, UpdateDto, ListDto, T>.FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
