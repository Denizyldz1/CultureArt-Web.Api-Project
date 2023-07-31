using CultureArt.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.PublisherDtos
{
	public class PublisherDto : IEntityDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }
		public string? WebSiteHomePageUrl { get; set; }
	}
}
