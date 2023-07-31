using CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CultureArt.Data.Configurations
{
	internal class AddressDetailConfiguration : IEntityTypeConfiguration<AddressDetail>
	{
		public void Configure(EntityTypeBuilder<AddressDetail> builder)
		{
			builder.Property(x => x.StreetAddress).IsRequired();
			builder.Property(x => x.PostCode).IsRequired();
			builder.Property(x =>x.EventAreaName).IsRequired().HasMaxLength(1000);
			builder.HasOne(x=>x.City).WithMany(x => x.AddressDetails).HasForeignKey(x=>x.CityId).OnDelete(DeleteBehavior.Restrict);
			builder.HasData(new AddressDetail()
			{
				Id = 1,
				StreetAddress = "Harbiye, Kadırgalar Cd. No:4 Şişli",
				PostCode= 34367,
				CityId = 34,
				EventAreaName = "Küçük Çiftlik Park"
			});


		}
	}
}
