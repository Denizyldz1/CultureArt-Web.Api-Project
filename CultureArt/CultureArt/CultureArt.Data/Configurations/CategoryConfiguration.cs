using CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CultureArt.Data.Configurations
{
	internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

			builder.HasData(new Category()
			{
				Id = 1,
				Name = "Müzikli Festival"
			}, new Category()
			{
				Id = 2,
				Name = "Sahne"
			},
			new Category()
			{
				Id = 3,
				Name = "Spor"
			}
			);
		}
	}
}
