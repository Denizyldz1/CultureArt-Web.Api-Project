﻿// <auto-generated />
using System;
using CultureArt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CultureArt.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230723210820_updateEntityEvent")]
    partial class updateEntityEvent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CultureArt.Core.Entities.AddressDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostCode")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("AddressDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 34,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostCode = 34367,
                            StreetAddress = "Harbiye, Kadırgalar Cd. No:4 Şişli"
                        });
                });

            modelBuilder.Entity("CultureArt.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Müzikli Festival"
                        });
                });

            modelBuilder.Entity("CultureArt.Core.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Adana"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Adıyaman"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Afyonkarahisar"
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Ağrı"
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Amasya"
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Ankara"
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Antalya"
                        },
                        new
                        {
                            Id = 8,
                            CityName = "Artvin"
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Aydın"
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Balıkesir"
                        },
                        new
                        {
                            Id = 11,
                            CityName = "Bilecik"
                        },
                        new
                        {
                            Id = 12,
                            CityName = "Bingöl"
                        },
                        new
                        {
                            Id = 13,
                            CityName = "Bitlis"
                        },
                        new
                        {
                            Id = 14,
                            CityName = "Bolu"
                        },
                        new
                        {
                            Id = 15,
                            CityName = "Burdur"
                        },
                        new
                        {
                            Id = 16,
                            CityName = "Bursa"
                        },
                        new
                        {
                            Id = 17,
                            CityName = "Çanakkale"
                        },
                        new
                        {
                            Id = 18,
                            CityName = "Çankırı"
                        },
                        new
                        {
                            Id = 19,
                            CityName = "Çorum"
                        },
                        new
                        {
                            Id = 20,
                            CityName = "Denizli"
                        },
                        new
                        {
                            Id = 21,
                            CityName = "Diyarbakır"
                        },
                        new
                        {
                            Id = 22,
                            CityName = "Edirne"
                        },
                        new
                        {
                            Id = 23,
                            CityName = "Elazığ"
                        },
                        new
                        {
                            Id = 24,
                            CityName = "Erzincan"
                        },
                        new
                        {
                            Id = 25,
                            CityName = "Erzurum"
                        },
                        new
                        {
                            Id = 26,
                            CityName = "Eskişehir"
                        },
                        new
                        {
                            Id = 27,
                            CityName = "Gaziantep"
                        },
                        new
                        {
                            Id = 28,
                            CityName = "Giresun"
                        },
                        new
                        {
                            Id = 29,
                            CityName = "Gümüşhane"
                        },
                        new
                        {
                            Id = 30,
                            CityName = "Hakkari"
                        },
                        new
                        {
                            Id = 31,
                            CityName = "Hatay"
                        },
                        new
                        {
                            Id = 32,
                            CityName = "Isparta"
                        },
                        new
                        {
                            Id = 33,
                            CityName = "Mersin"
                        },
                        new
                        {
                            Id = 34,
                            CityName = "İstanbul"
                        },
                        new
                        {
                            Id = 35,
                            CityName = "İzmir"
                        },
                        new
                        {
                            Id = 36,
                            CityName = "Kars"
                        },
                        new
                        {
                            Id = 37,
                            CityName = "Kastamonu"
                        },
                        new
                        {
                            Id = 38,
                            CityName = "Kayseri"
                        },
                        new
                        {
                            Id = 39,
                            CityName = "Kırklareli"
                        },
                        new
                        {
                            Id = 40,
                            CityName = "Kırşehir"
                        },
                        new
                        {
                            Id = 41,
                            CityName = "Kocaeli"
                        },
                        new
                        {
                            Id = 42,
                            CityName = "Konya"
                        },
                        new
                        {
                            Id = 43,
                            CityName = "Kütahya"
                        },
                        new
                        {
                            Id = 44,
                            CityName = "Malatya"
                        },
                        new
                        {
                            Id = 45,
                            CityName = "Manisa"
                        },
                        new
                        {
                            Id = 46,
                            CityName = "Kahramanmaraş"
                        },
                        new
                        {
                            Id = 47,
                            CityName = "Mardin"
                        },
                        new
                        {
                            Id = 48,
                            CityName = "Muğla"
                        },
                        new
                        {
                            Id = 49,
                            CityName = "Muş"
                        },
                        new
                        {
                            Id = 50,
                            CityName = "Nevşehir"
                        },
                        new
                        {
                            Id = 51,
                            CityName = "Niğde"
                        },
                        new
                        {
                            Id = 52,
                            CityName = "Ordu"
                        },
                        new
                        {
                            Id = 53,
                            CityName = "Rize"
                        },
                        new
                        {
                            Id = 54,
                            CityName = "Sakarya"
                        },
                        new
                        {
                            Id = 55,
                            CityName = "Samsun"
                        },
                        new
                        {
                            Id = 56,
                            CityName = "Siirt"
                        },
                        new
                        {
                            Id = 57,
                            CityName = "Sinop"
                        },
                        new
                        {
                            Id = 58,
                            CityName = "Sivas"
                        },
                        new
                        {
                            Id = 59,
                            CityName = "Tekirdağ"
                        },
                        new
                        {
                            Id = 60,
                            CityName = "Tokat"
                        },
                        new
                        {
                            Id = 61,
                            CityName = "Trabzon"
                        },
                        new
                        {
                            Id = 62,
                            CityName = "Tunceli"
                        },
                        new
                        {
                            Id = 63,
                            CityName = "Şanlıurfa"
                        },
                        new
                        {
                            Id = 64,
                            CityName = "Uşak"
                        },
                        new
                        {
                            Id = 65,
                            CityName = "Van"
                        },
                        new
                        {
                            Id = 66,
                            CityName = "Yozgat"
                        },
                        new
                        {
                            Id = 67,
                            CityName = "Zonguldak"
                        },
                        new
                        {
                            Id = 68,
                            CityName = "Aksaray"
                        },
                        new
                        {
                            Id = 69,
                            CityName = "Bayburt"
                        },
                        new
                        {
                            Id = 70,
                            CityName = "Karaman"
                        },
                        new
                        {
                            Id = 71,
                            CityName = "Kırıkkale"
                        },
                        new
                        {
                            Id = 72,
                            CityName = "Batman"
                        },
                        new
                        {
                            Id = 73,
                            CityName = "Şırnak"
                        },
                        new
                        {
                            Id = 74,
                            CityName = "Bartın"
                        },
                        new
                        {
                            Id = 75,
                            CityName = "Ardahan"
                        },
                        new
                        {
                            Id = 76,
                            CityName = "Iğdır"
                        },
                        new
                        {
                            Id = 77,
                            CityName = "Yalova"
                        },
                        new
                        {
                            Id = 78,
                            CityName = "Karabük"
                        },
                        new
                        {
                            Id = 79,
                            CityName = "Kilis"
                        },
                        new
                        {
                            Id = 80,
                            CityName = "Osmaniye"
                        },
                        new
                        {
                            Id = 81,
                            CityName = "Düzce"
                        });
                });

            modelBuilder.Entity("CultureArt.Core.Entities.CultureArt.Core.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyAddress = "Kadırgalar Cad. No:4 ŞİŞLİ / İstanbul",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KüçükÇiftlik Park"
                        });
                });

            modelBuilder.Entity("CultureArt.Core.Entities.CultureArt.Core.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebSiteHomePageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Biletix",
                            WebSiteHomePageUrl = "https://www.biletix.com/"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Biletino",
                            WebSiteHomePageUrl = "https://biletino.com/tr"
                        });
                });

            modelBuilder.Entity("CultureArt.Core.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressDetailId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EventEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EventStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventStatus")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressDetailId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressDetailId = 1,
                            CategoryId = 1,
                            CityId = 34,
                            CompanyId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventEndDate = new DateTime(2023, 8, 6, 23, 55, 0, 0, DateTimeKind.Unspecified),
                            EventStartDate = new DateTime(2023, 8, 5, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            EventStatus = 1,
                            ImageUrl = "Deneme",
                            Name = "İstanbul Cocktail Festival 2023",
                            PublisherId = 1
                        });
                });

            modelBuilder.Entity("CultureArt.Core.Entities.EventFeature", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventRules")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventFeature");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.PublisherCompany", b =>
                {
                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("PublisherId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("PublisherCompany");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.AddressDetail", b =>
                {
                    b.HasOne("CultureArt.Core.Entities.City", "City")
                        .WithMany("AddressDetails")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.Event", b =>
                {
                    b.HasOne("CultureArt.Core.Entities.AddressDetail", "AddressDetail")
                        .WithMany("Events")
                        .HasForeignKey("AddressDetailId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CultureArt.Core.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CultureArt.Core.Entities.City", "City")
                        .WithMany("Events")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CultureArt.Core.Entities.CultureArt.Core.Entities.Company", "Company")
                        .WithMany("Events")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CultureArt.Core.Entities.CultureArt.Core.Entities.Publisher", "Publisher")
                        .WithMany("Events")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressDetail");

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("Company");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.EventFeature", b =>
                {
                    b.HasOne("CultureArt.Core.Entities.Event", "Event")
                        .WithOne("EventFeature")
                        .HasForeignKey("CultureArt.Core.Entities.EventFeature", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.PublisherCompany", b =>
                {
                    b.HasOne("CultureArt.Core.Entities.CultureArt.Core.Entities.Company", "Company")
                        .WithMany("Publishers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CultureArt.Core.Entities.CultureArt.Core.Entities.Publisher", "Publisher")
                        .WithMany("Companies")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.AddressDetail", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.Category", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.City", b =>
                {
                    b.Navigation("AddressDetails");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.CultureArt.Core.Entities.Company", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Publishers");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.CultureArt.Core.Entities.Publisher", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("CultureArt.Core.Entities.Event", b =>
                {
                    b.Navigation("EventFeature");
                });
#pragma warning restore 612, 618
        }
    }
}
