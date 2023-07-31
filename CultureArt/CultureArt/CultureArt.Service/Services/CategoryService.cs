using AutoMapper;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.CategoryDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;

namespace CultureArt.Service.Services
{
	public class CategoryService : Service<CategoryDto, Category>, ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;
		public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork, mapper)
		{
			_categoryRepository = categoryRepository;
		}
		protected override CategoryDto MapToDto(Category entity)
		{
			return _mapper.Map<CategoryDto>(entity);
		}

		public async Task<CustomResponseDto<CreateCategoryDto>> AddAsync(CreateCategoryDto dto)
		{
			var entity = _mapper.Map<Category>(dto);
			await _categoryRepository.AddAsync(entity);
			await _unitOfWork.CommitAsync();
			var categoryDto = _mapper.Map<CreateCategoryDto>(entity);
			return CustomResponseDto<CreateCategoryDto>.Success(201, categoryDto);
		}

		public async Task<CustomResponseDto<IEnumerable<CreateCategoryDto>>> AddRandeAsync(IEnumerable<CreateCategoryDto> dtos)
		{
			var entities = _mapper.Map<IEnumerable<Category>>(dtos);
			await _categoryRepository.AddRangeAsync(entities);
			await _unitOfWork.CommitAsync();
			var categoryDtos = _mapper.Map<IEnumerable<CreateCategoryDto>>(entities);
			return CustomResponseDto<IEnumerable<CreateCategoryDto>>.Success(201, categoryDtos);
		}

		public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
		{
			var value = await _categoryRepository.GetByIdAsync(id);
			_categoryRepository.Remove(value);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateCategoryDto dto)
		{
			var value = _mapper.Map<Category>(dto);
			_categoryRepository.Update(value);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);

		}

		public async Task<CustomResponseDto<CategoryWithEventDto>> GetSingleCategoryByIdWithEventAsync(int categoryId)
		{
			var category = await _categoryRepository.GetSingleCategoryByIdWithEventAsync(categoryId);
			var categoryDto =  _mapper.Map<CategoryWithEventDto>(category);
			return CustomResponseDto<CategoryWithEventDto>.Success(200, categoryDto);
		}
	}
}
