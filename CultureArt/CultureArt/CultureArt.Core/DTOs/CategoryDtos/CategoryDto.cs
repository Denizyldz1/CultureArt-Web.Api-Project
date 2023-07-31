using CultureArt.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.CategoryDtos
{
	public class CategoryDto:IEntityDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }
	}
}
