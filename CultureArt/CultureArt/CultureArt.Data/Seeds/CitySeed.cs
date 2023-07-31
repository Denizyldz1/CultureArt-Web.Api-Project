using CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureArt.Data.Seeds
{
	internal class CitySeed : IEntityTypeConfiguration<City>
	{
		public void Configure(EntityTypeBuilder<City> builder)
		{
			builder.HasData(
			new City() { Id = 1, CityName = "Adana" },
			new City() { Id = 2, CityName = "Adıyaman" },
			new City() { Id = 3, CityName = "Afyonkarahisar" },
			new City() { Id = 4, CityName = "Ağrı" },
			new City() { Id = 5, CityName = "Amasya" },
			new City() { Id = 6, CityName = "Ankara" },
			new City() { Id = 7, CityName = "Antalya" },
			new City() { Id = 8, CityName = "Artvin" },
			new City() { Id = 9, CityName = "Aydın" },
			new City() { Id = 10, CityName = "Balıkesir" },
			new City() { Id = 11, CityName = "Bilecik" },
			new City() { Id = 12, CityName = "Bingöl" },
			new City() { Id = 13, CityName = "Bitlis" },
			new City() { Id = 14, CityName = "Bolu" },
			new City() { Id = 15, CityName = "Burdur" },
			new City() { Id = 16, CityName = "Bursa" },
			new City() { Id = 17, CityName = "Çanakkale" },
			new City() { Id = 18, CityName = "Çankırı" },
			new City() { Id = 19, CityName = "Çorum" },
			new City() { Id = 20, CityName = "Denizli" },
			new City() { Id = 21, CityName = "Diyarbakır" },
			new City() { Id = 22, CityName = "Edirne" },
			new City() { Id = 23, CityName = "Elazığ" },
			new City() { Id = 24, CityName = "Erzincan" },
			new City() { Id = 25, CityName = "Erzurum" },
			new City() { Id = 26, CityName = "Eskişehir" },
			new City() { Id = 27, CityName = "Gaziantep" },
			new City() { Id = 28, CityName = "Giresun" },
			new City() { Id = 29, CityName = "Gümüşhane" },
			new City() { Id = 30, CityName = "Hakkari" },
			new City() { Id = 31, CityName = "Hatay" },
			new City() { Id = 32, CityName = "Isparta" },
			new City() { Id = 33, CityName = "Mersin" },
			new City() { Id = 34, CityName = "İstanbul" },
			new City() { Id = 35, CityName = "İzmir" },
			new City() { Id = 36, CityName = "Kars" },
			new City() { Id = 37, CityName = "Kastamonu" },
			new City() { Id = 38, CityName = "Kayseri" },
			new City() { Id = 39, CityName = "Kırklareli" },
			new City() { Id = 40, CityName = "Kırşehir" },
			new City() { Id = 41, CityName = "Kocaeli" },
			new City() { Id = 42, CityName = "Konya" },
			new City() { Id = 43, CityName = "Kütahya" },
			new City() { Id = 44, CityName = "Malatya" },
			new City() { Id = 45, CityName = "Manisa" },
			new City() { Id = 46, CityName = "Kahramanmaraş" },
			new City() { Id = 47, CityName = "Mardin" },
			new City() { Id = 48, CityName = "Muğla" },
			new City() { Id = 49, CityName = "Muş" },
			new City() { Id = 50, CityName = "Nevşehir" },
			new City() { Id = 51, CityName = "Niğde" },
			new City() { Id = 52, CityName = "Ordu" },
			new City() { Id = 53, CityName = "Rize" },
			new City() { Id = 54, CityName = "Sakarya" },
			new City() { Id = 55, CityName = "Samsun" },
			new City() { Id = 56, CityName = "Siirt" },
			new City() { Id = 57, CityName = "Sinop" },
			new City() { Id = 58, CityName = "Sivas" },
			new City() { Id = 59, CityName = "Tekirdağ" },
			new City() { Id = 60, CityName = "Tokat" },
			new City() { Id = 61, CityName = "Trabzon" },
			new City() { Id = 62, CityName = "Tunceli" },
			new City() { Id = 63, CityName = "Şanlıurfa" },
			new City() { Id = 64, CityName = "Uşak" },
			new City() { Id = 65, CityName = "Van" },
			new City() { Id = 66, CityName = "Yozgat" },
			new City() { Id = 67, CityName = "Zonguldak" },
			new City() { Id = 68, CityName = "Aksaray" },
			new City() { Id = 69, CityName = "Bayburt" },
			new City() { Id = 70, CityName = "Karaman" },
			new City() { Id = 71, CityName = "Kırıkkale" },
			new City() { Id = 72, CityName = "Batman" },
			new City() { Id = 73, CityName = "Şırnak" },
			new City() { Id = 74, CityName = "Bartın" },
			new City() { Id = 75, CityName = "Ardahan" },
			new City() { Id = 76, CityName = "Iğdır" },
			new City() { Id = 77, CityName = "Yalova" },
			new City() { Id = 78, CityName = "Karabük" },
			new City() { Id = 79, CityName = "Kilis" },
			new City() { Id = 80, CityName = "Osmaniye" },
			new City() { Id = 81, CityName = "Düzce" }

			);
		}
	}
}
