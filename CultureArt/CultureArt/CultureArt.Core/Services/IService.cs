using CultureArt.Core.Dto;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.Entities;
using System.Linq.Expressions;

namespace CultureArt.Core.Services
{
	public interface IService<TDto,T> :IBaseService<T>
	{
		// Sadece Ortak Crud İşlemlerini Ekliyorum

		Task<CustomResponseDto<TDto>> GetByIdAsync(int id);

		Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync();

		//Task<CustomResponseDto<TDto>> AddAsync(TDto dto);

		//Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<T> dtos);

		//Task<CustomResponseDto<NoContentDto>> UpdateAsync(TDto dto);

		//Task<CustomResponseDto<NoContentDto>> RemoveAsync(TDto dto);
		//Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<T> entities);
		//IQueryable<T> Where(Expression<Func<T, bool>> expression);
	}
}
