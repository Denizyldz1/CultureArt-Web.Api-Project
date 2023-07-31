using CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CultureArt.Data.Configurations
{
	internal class CityConfiguration : IEntityTypeConfiguration<City>
	{
		public void Configure(EntityTypeBuilder<City> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x=>x.Id).UseIdentityColumn();
			builder.Property(x => x.CityName).IsRequired().HasMaxLength(50);		}
	}
}
