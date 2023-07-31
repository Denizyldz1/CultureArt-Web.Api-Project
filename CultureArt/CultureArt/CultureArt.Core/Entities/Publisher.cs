namespace CultureArt.Core.Entities
{
	namespace CultureArt.Core.Entities
	{
		public class Publisher : BaseEntity
		{
            public string? Name { get; set; }
			public string? WebSiteHomePageUrl { get; set; }
			public ICollection<PublisherEvent>? Events { get; set; }

		}
	}
}
