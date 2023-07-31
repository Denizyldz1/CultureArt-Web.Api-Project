using CultureArt.Core.Entities;
using CultureArt.Core.Entities.CultureArt.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CultureArt.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{ }

		public DbSet<City> Cities { get; set; }
		public DbSet<AddressDetail> AddressDetails { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Publisher> Publishers { get; set; }
		public DbSet<EventFeature> EventsFeature { get; set; }
		public DbSet<PublisherEvent> PublisherEvents { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Burada çalıştığımız library'deki Assembly tarar ve yazmamızın önüne geçer
			//IEntityTypeConfiguration interface ımplement eden sınıfları bulur

			modelBuilder.Entity<PublisherEvent>().HasData(
				new PublisherEvent
				{
					PublisherId = 1,
					EventId = 1,
					PublisherEventUrl= "https://www.biletix.com/etkinlik/2WW03/TURKIYE/tr"
                },
				new PublisherEvent
				{
					PublisherId= 2,
					EventId= 1
				}
				);
			modelBuilder.Entity<EventFeature>().HasData(
				new EventFeature
				{
					Id = 1,
					Title = "İstanbul Cocktail Festival 2023",
					Description = "Gastronomi ve miksoloji dünyasının yıldızı kokteyllerin Türkiye’deki ilk ve tek festivali İstanbul Cocktail Festival, 5-6 Ağustos tarihlerinde altıncı kez KüçükÇiftlik Park’ta!\r\n\r\nPopüler kokteyl duraklarının en sevilen sunumları, uzman miksolojistler ve gurmelerden atölyeler, lokal ve küresel sahnenin önemli temsilcilerinden performanslar, her damak tadına hitap edecek yemek alanı, özgün butiklerin tasarım ürünleri, gün boyu sürecek aktiviteler ve oyunlar ile renklenecek İstanbul Cocktail Festival’inde buluşalım.\r\n\r\nMüzik\r\n\r\n5 Ağustos Cumartesi\r\n\r\nİlhan Erşahin & Kaan Düzarat\r\nKöfn\r\nMert Demir\r\nSelin\r\nUmutcan Genç\r\n\r\n6 Ağustos Pazar\r\n\r\nElderbrook Live\r\nEmir Taha\r\nDeniz Sipahi\r\nMertkan Akd\r\nEylülsu\r\n\r\nKokteyl Barlar\r\n(a-z)\r\n\r\nBlok.Mekan\r\nFinn Karaköy\r\nKorto İstanbul\r\nMathilda's Cocktail Bar\r\nRanchero Mexican Restaurant"
				,
					EventRules = "- Festival bileti yalnızca festival alanına girişi kapsamaktadır. İçeride gerçekleşecek tüm servis atölye ve aktiviteler ücretli olarak gerçekleşecektir.\r\n- 18 yaş altı katılımcıların festival alanına girişi yasaktır.\r\n- Festival ekibi festival için uygun görmediği kişileri bilet ücretini iade etmek kaydı ile içeri almama hakkına sahiptir.\r\n- Festival ekibi, öngörülmeyen ve kaçınılmaz nedenlerden ötürü programda her türlü değişiklik yapma hakkını saklı tutar.\r\n- Festival ekibi, bilet fiyatlarında değişiklik yapma hakkına sahiptir.\r\n- Festival süresince biletinizi ve/ veya bilekliğinizi saklayınız.\r\n- Festival alanına dışarıdan yiyecek ve içecek getirilmesi yasaktır.\r\n- Festival alanına profesyonel ses ve görüntü araçları (video kamera ve fotoğraf makinası) ile girmek yasaktır.\r\n- Festival alanına yanıcı, patlayıcı (deodorant, sprey, parfüm vb. gibi), parlayıcı, kesici ve delici olarak kullanılabilecek her türlü alet ve lazer imleci ile girmek yasaktır.\r\n- Tüm katılımcıların kimliklerini yanlarında bulundurması ve istendiğinde ibraz etmeleri gerekmektedir.\r\n- Festival alanında yanınızda bulunan eşyaların sorumluluğunun size ait olduğunu hatırlatmak isteriz.\r\n- Güvenlik personeli, etkinlik alanına giren herkesi güvenlik aramasına tabii tutacaktır.\r\n- Festival alanındaki ses düzenleri geçici duyma problemlerine yol açabilir.\r\n- Festival alanındaki ışık düzenleri geçici göz rahatsızlıklarına neden olabilir.\r\n- Festival biletleri sadece festival ekibi tarafından belirlenen resmi satış noktalarından alınmalıdır. Organizasyon sahibi resmi satış noktalarından alınmayan biletlerin sahiplerini etkinlik alanından çıkarma hakkına sahiptir.\r\n- Festival alanına giriş yapan seyircilerin alandan çıkış yapmaları halinde tekrar alana girebilmeleri için yeni bilet satın almaları gerekmektedir.  \r\n- Festival biletleri devredilemez ve iade edilemez. Kayıp biletler için yenisi basılmayacaktır.\r\n- Festivale katılan kişilerin fotoğraf ve video çekimlerinin tanıtım materyallerinde kullanım hakkı etkinlik organizasyonuna ait olup katılımcı, etkinliğe katılarak bu hakkın kullanılmasını kabul etmektedir."
				});
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
