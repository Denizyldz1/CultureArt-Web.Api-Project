using CultureArt.Core.Entities.CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CultureArt.Data.Configurations
{
	internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
	{
		public void Configure(EntityTypeBuilder<Publisher> builder)
		{
	    	builder.HasKey(x => x.Id);
	    	builder.Property(x => x.Id).UseIdentityColumn();
	    	builder.Property(x => x.Name).IsRequired();
			builder.Property(x=>x.WebSiteHomePageUrl).IsRequired(false);
			builder.HasData(new Publisher()
			{
				Id = 1,
				Name = "Biletix",
				WebSiteHomePageUrl = "https://www.biletix.com/"
			},
				new Publisher()
				{
					Id = 2,
					Name = "Biletino",
					WebSiteHomePageUrl = "https://biletino.com/tr"

				});
		}
	}
}
