using AutoMapper;
using CultureArt.Core.Dto;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CultureArt.Service.Services
{
	public abstract class Service<TDto, T> : IService<TDto, T> where T : class, IEntity where TDto : class,IEntityDto,new()
	{
		private readonly IGenericRepository<T> _repository;
		protected readonly IUnitOfWork _unitOfWork;
		protected readonly IMapper _mapper;

		public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
		{
			_repository = repository;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		//protected abstract T MapToEntity(TDto dto);
		protected abstract TDto MapToDto(T entity);

		public virtual async Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync()
		{
			var entities = await _repository.GetAll().ToListAsync();
			var dtoEntities = new List<TDto>();
			entities.ForEach(entity => { dtoEntities.Add(MapToDto(entity)); });
			return CustomResponseDto<IEnumerable<TDto>>.Success(200, dtoEntities);
		}

		public async Task<CustomResponseDto<TDto>> GetByIdAsync(int id)
		{
			var entity = await _repository.GetByIdAsync(id);
			var dtoEntity = MapToDto(entity);
			return CustomResponseDto<TDto>.Success(200, dtoEntity);
		}

		public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
		{
			return await _repository.AnyAsync(expression);
		}

		//public async Task<CustomResponseDto<TDto>> AddAsync(TDto dto)
		//{
		//	var entity = MapToEntity(dto);
		//	await _repository.AddAsync(entity);
		//	await _unitOfWork.CommitAsync();
		//	var entityDto = MapToDto(entity);
		//	return CustomResponseDto<TDto>.Success(200, entityDto);
		//}

		//public Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<T> dtos)
		//{
		//	throw new NotImplementedException();
		//}

		//public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
		//{
		//	throw new NotImplementedException();
		//}

		//public Task<CustomResponseDto<NoContentDto>> RemoveAsync(TDto dto)
		//{
		//	throw new NotImplementedException();
		//}

		//public Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<T> entities)
		//{
		//	throw new NotImplementedException();
		//}

		//public Task<CustomResponseDto<NoContentDto>> UpdateAsync(TDto dto)
		//{
		//	throw new NotImplementedException();
		//}

		//public IQueryable<T> Where(Expression<Func<T, bool>> expression)
		//{
		//	throw new NotImplementedException();
		//}
	}
}
