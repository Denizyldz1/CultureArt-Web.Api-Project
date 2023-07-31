using CultureArt.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.AddressDetailDtos
{
	public class CreateAddressDetailDto : BaseCreateDto
	{
        public string? EventAreaName { get; set; }
        public string? StreetAddress { get; set; }
		public int PostCode { get; set; }
		public int CityId { get; set; }
	}
}
