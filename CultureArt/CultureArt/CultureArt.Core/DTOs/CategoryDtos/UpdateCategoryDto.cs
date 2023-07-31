using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs.CategoryDtos
{
	public class UpdateCategoryDto : BaseUpdateDto
	{
		public string? Name { get; set; }
	}
}
