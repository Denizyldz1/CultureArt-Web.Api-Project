using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CultureArt.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sahne", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spor", null }
                });

            migrationBuilder.InsertData(
                table: "EventFeature",
                columns: new[] { "Id", "Description", "EventRules", "EventUrl", "Title" },
                values: new object[] { 1, "Gastronomi ve miksoloji dünyasının yıldızı kokteyllerin Türkiye’deki ilk ve tek festivali İstanbul Cocktail Festival, 5-6 Ağustos tarihlerinde altıncı kez KüçükÇiftlik Park’ta!\r\n\r\nPopüler kokteyl duraklarının en sevilen sunumları, uzman miksolojistler ve gurmelerden atölyeler, lokal ve küresel sahnenin önemli temsilcilerinden performanslar, her damak tadına hitap edecek yemek alanı, özgün butiklerin tasarım ürünleri, gün boyu sürecek aktiviteler ve oyunlar ile renklenecek İstanbul Cocktail Festival’inde buluşalım.\r\n\r\nMüzik\r\n\r\n5 Ağustos Cumartesi\r\n\r\nİlhan Erşahin & Kaan Düzarat\r\nKöfn\r\nMert Demir\r\nSelin\r\nUmutcan Genç\r\n\r\n6 Ağustos Pazar\r\n\r\nElderbrook Live\r\nEmir Taha\r\nDeniz Sipahi\r\nMertkan Akd\r\nEylülsu\r\n\r\nKokteyl Barlar\r\n(a-z)\r\n\r\nBlok.Mekan\r\nFinn Karaköy\r\nKorto İstanbul\r\nMathilda's Cocktail Bar\r\nRanchero Mexican Restaurant", "- Festival bileti yalnızca festival alanına girişi kapsamaktadır. İçeride gerçekleşecek tüm servis atölye ve aktiviteler ücretli olarak gerçekleşecektir.\r\n- 18 yaş altı katılımcıların festival alanına girişi yasaktır.\r\n- Festival ekibi festival için uygun görmediği kişileri bilet ücretini iade etmek kaydı ile içeri almama hakkına sahiptir.\r\n- Festival ekibi, öngörülmeyen ve kaçınılmaz nedenlerden ötürü programda her türlü değişiklik yapma hakkını saklı tutar.\r\n- Festival ekibi, bilet fiyatlarında değişiklik yapma hakkına sahiptir.\r\n- Festival süresince biletinizi ve/ veya bilekliğinizi saklayınız.\r\n- Festival alanına dışarıdan yiyecek ve içecek getirilmesi yasaktır.\r\n- Festival alanına profesyonel ses ve görüntü araçları (video kamera ve fotoğraf makinası) ile girmek yasaktır.\r\n- Festival alanına yanıcı, patlayıcı (deodorant, sprey, parfüm vb. gibi), parlayıcı, kesici ve delici olarak kullanılabilecek her türlü alet ve lazer imleci ile girmek yasaktır.\r\n- Tüm katılımcıların kimliklerini yanlarında bulundurması ve istendiğinde ibraz etmeleri gerekmektedir.\r\n- Festival alanında yanınızda bulunan eşyaların sorumluluğunun size ait olduğunu hatırlatmak isteriz.\r\n- Güvenlik personeli, etkinlik alanına giren herkesi güvenlik aramasına tabii tutacaktır.\r\n- Festival alanındaki ses düzenleri geçici duyma problemlerine yol açabilir.\r\n- Festival alanındaki ışık düzenleri geçici göz rahatsızlıklarına neden olabilir.\r\n- Festival biletleri sadece festival ekibi tarafından belirlenen resmi satış noktalarından alınmalıdır. Organizasyon sahibi resmi satış noktalarından alınmayan biletlerin sahiplerini etkinlik alanından çıkarma hakkına sahiptir.\r\n- Festival alanına giriş yapan seyircilerin alandan çıkış yapmaları halinde tekrar alana girebilmeleri için yeni bilet satın almaları gerekmektedir.  \r\n- Festival biletleri devredilemez ve iade edilemez. Kayıp biletler için yenisi basılmayacaktır.\r\n- Festivale katılan kişilerin fotoğraf ve video çekimlerinin tanıtım materyallerinde kullanım hakkı etkinlik organizasyonuna ait olup katılımcı, etkinliğe katılarak bu hakkın kullanılmasını kabul etmektedir.", "https://www.biletix.com/etkinlik/2WW03/TURKIYE/tr", "İstanbul Cocktail Festival 2023" });

            migrationBuilder.InsertData(
                table: "PublisherCompany",
                columns: new[] { "CompanyId", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventFeature",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublisherCompany",
                keyColumns: new[] { "CompanyId", "PublisherId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PublisherCompany",
                keyColumns: new[] { "CompanyId", "PublisherId" },
                keyValues: new object[] { 1, 2 });
        }
    }
}
