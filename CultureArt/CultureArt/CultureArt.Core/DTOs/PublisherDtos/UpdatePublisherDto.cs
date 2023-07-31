namespace CultureArt.Core.DTOs.PublisherDtos
{
	public class UpdatePublisherDto : BaseUpdateDto
	{
		public string? Name { get; set; }
		public string? WebSiteHomePageUrl { get; set; }
	}
}
