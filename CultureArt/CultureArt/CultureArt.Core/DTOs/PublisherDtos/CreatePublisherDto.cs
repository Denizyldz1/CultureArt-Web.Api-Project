using CultureArt.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.PublisherDtos
{
	public class CreatePublisherDto : BaseCreateDto
	{
		public string? Name { get; set; }
		public string? WebSiteHomePageUrl { get; set; }
	}
}
