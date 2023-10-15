using AutoMapper;
using MainApp.Application.Enums;
using MainApp.Application.Interfaces.Dtos;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Application.Wrappers;
using MainApp.Domain.Common;
using System.Linq.Expressions;

namespace MainApp.Application.Services
{
    public class Service<CreateDto, UpdateDto, ListDto, T> : IService<CreateDto, UpdateDto, ListDto, T>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public Service(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public bool Any()
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public T Find(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<ListDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            throw new NotImplementedException();
        }

        public T GetByFilter(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetQuery()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public string ToQueryString()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        //public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        //{
        //    var validationResult = _createValidator.Validate(dto);
        //    if (validationResult.IsValid)
        //    {
        //        T createdEntity = _mapper.Map<T>(dto);
        //        await _uow.GetRepository<T>().CreateAsync(createdEntity);
        //        return new Response<CreateDto>(ResponseType.Success, dto);
        //    }
        //    return new Response<CreateDto>(dto, new());
        //    throw new NotImplementedException();
        //}

        //public async Task<IResponse<IDto>> FindAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IResponse<List<ListDto>>> GetAllAsync()
        //{
        //    var data = await _uow.GetRepository<T>().GetAllAsync();
        //    var dto = _mapper.Map<List<ListDto>>(data);
        //    return new Response<List<ListDto>>(ResponseType.Success, dto);
        //}

    }
}
