using CultureArt.Core.DTOs.AddressDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.CityDtos
{
	public class CityWithAddressDetailDto: CityDto
	{
		public List<AddressDetailDto>? AddressDetails { get; set; }
	}
}
