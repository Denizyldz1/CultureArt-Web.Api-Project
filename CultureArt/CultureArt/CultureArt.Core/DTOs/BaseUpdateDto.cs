using CultureArt.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CultureArt.Core.DTOs
{
	public class BaseUpdateDto : IEntityDto
	{
        public int Id { get; set; }
	}
}
