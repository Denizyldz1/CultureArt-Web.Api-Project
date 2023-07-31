using CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CultureArt.Data.Configurations
{
	public class PublisherEventConfiguration : IEntityTypeConfiguration<PublisherEvent>
	{
		public void Configure(EntityTypeBuilder<PublisherEvent> builder)
		{
			builder.HasKey(x=> new {x.PublisherId, x.EventId});
			builder.HasOne(x=>x.Publisher).WithMany(x=>x.Events).HasForeignKey(x=>x.PublisherId);
			builder.HasOne(x=>x.Event).WithMany(x=>x.Publishers).HasForeignKey(x=>x.EventId);
		}
	}
}
