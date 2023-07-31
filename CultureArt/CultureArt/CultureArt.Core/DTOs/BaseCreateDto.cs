using System.Text.Json.Serialization;

namespace CultureArt.Core.Dto
{
	public class BaseCreateDto : IEntityDto
	{
        public int Id { get; set; }
	}
}
