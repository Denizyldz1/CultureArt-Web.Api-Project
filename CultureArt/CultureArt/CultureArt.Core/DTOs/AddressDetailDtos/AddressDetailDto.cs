using CultureArt.Core.Dto;
using CultureArt.Core.DTOs.CityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.AddressDetailDtos
{
	public class AddressDetailDto:IEntityDto
	{
        public int Id { get; set; }
        public string? EventAreaName { get; set; }

        public string? StreetAddress { get; set; }
		public int PostCode { get; set; }

		public int CityId { get; set; }
	}
}
