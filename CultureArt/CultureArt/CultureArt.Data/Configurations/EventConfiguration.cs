using CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CultureArt.Data.Configurations
{
	internal class EventConfiguration : IEntityTypeConfiguration<Event>
	{
		public void Configure(EntityTypeBuilder<Event> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.Name).IsRequired();

			builder.HasOne(x => x.AddressDetail).WithMany(x => x.Events).HasForeignKey(x => x.AddressDetailId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(x => x.Category).WithMany(x => x.Events).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(x => x.City).WithMany(x => x.Events).HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.Restrict);
			builder.HasData(new Event()
			{
				Id = 1,
				Name = "İstanbul Cocktail Festival 2023",
				EventStartDate = new DateTime(2023, 8, 5, 13, 0, 0),
				EventEndDate = new DateTime(2023, 8, 6, 23, 55, 0),
				EventStatus = Core.Enums.EventStatus.Aktif,
				ImageUrl = "Deneme",
				AddressDetailId = 1,
				CategoryId = 1,
				CityId=34
		});
		}
	}
}
