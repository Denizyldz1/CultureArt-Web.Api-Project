using CultureArt.Core.DTOs.AddressDetailDtos;
using CultureArt.Core.DTOs.EventDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.CityDtos
{
	public class CityWithEventDto : CityDto
	{
		public List<EventDto>? Events { get; set; }
	}
}
