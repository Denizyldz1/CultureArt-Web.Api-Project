using AutoMapper;
using CultureArt.Core.Dto.CustomResponseDto;
using CultureArt.Core.Dto.NoContentDto;
using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.Entities;
using CultureArt.Core.Repositories;
using CultureArt.Core.Services;
using CultureArt.Core.UnitOfWorks;

namespace CultureArt.Service.Services
{
    public class AddressDetailService : Service<AddressDetailDto, AddressDetail>, IAddressDetailService
	{
		private readonly IAddressDetailRepository _addressDetailRepository;
		public AddressDetailService(IGenericRepository<AddressDetail> repository, IUnitOfWork unitOfWork, IMapper mapper, IAddressDetailRepository addressDetailRepository) : base(repository, unitOfWork, mapper)
		{
			_addressDetailRepository = addressDetailRepository;
		}
		protected override AddressDetailDto MapToDto(AddressDetail entity)
		{
			return _mapper.Map<AddressDetailDto>(entity);
		}


		public async Task<CustomResponseDto<CreateAddressDetailDto>> AddAsync(CreateAddressDetailDto dto)
		{
			var entity = _mapper.Map<AddressDetail>(dto);
			await _addressDetailRepository.AddAsync(entity);
			await _unitOfWork.CommitAsync();
			var addressDetailDto = _mapper.Map<CreateAddressDetailDto>(entity);
			return CustomResponseDto<CreateAddressDetailDto>.Success(201, addressDetailDto);

		}

		public async Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id)
		{
			var value = await _addressDetailRepository.GetByIdAsync(id);
			_addressDetailRepository.Remove(value);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(UpdateAddressDetailDto dto)
		{
			var value = _mapper.Map<AddressDetail>(dto);
			_addressDetailRepository.Update(value);
			await _unitOfWork.CommitAsync();
			return CustomResponseDto<NoContentDto>.Success(204);
		}

		public async Task<CustomResponseDto<List<AddressDetailWithCityDto>>> GetAddressDetailWithCityAsync()
		{
			var addressDetail = await _addressDetailRepository.GetAddressDetailWithCityAsync();
			var addressDetailDto = _mapper.Map<List<AddressDetailWithCityDto>>(addressDetail);
			return CustomResponseDto<List<AddressDetailWithCityDto>>.Success(200, addressDetailDto);
		}

		public async Task<CustomResponseDto<AddressDetailWithCityDto>> GetSingleAddressDetailByIdWithCityAsync(int addressDetailId)
		{
			var addressDetail = await _addressDetailRepository.GetSingleAddressDetailByIdWithCityAsync(addressDetailId);
			var addressDetailDto = _mapper.Map<AddressDetailWithCityDto>(addressDetail);
			return CustomResponseDto<AddressDetailWithCityDto>.Success(200, addressDetailDto);
		}
	}
}
