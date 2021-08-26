﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebScraper.Data;

namespace WebScraper.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210826173838_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebScraper.Data.Models.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Freight", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfLoading")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRemoval")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoadingTownId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnloadingTownId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LoadingTownId");

                    b.HasIndex("UnloadingTownId");

                    b.ToTable("Freights");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Town", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("WebScraper.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Freight", b =>
                {
                    b.HasOne("WebScraper.Data.Models.Company", null)
                        .WithMany("Freights")
                        .HasForeignKey("CompanyId");

                    b.HasOne("WebScraper.Data.Models.Town", "LoadingTown")
                        .WithMany()
                        .HasForeignKey("LoadingTownId");

                    b.HasOne("WebScraper.Data.Models.Town", "UnloadingTown")
                        .WithMany()
                        .HasForeignKey("UnloadingTownId");

                    b.Navigation("LoadingTown");

                    b.Navigation("UnloadingTown");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Town", b =>
                {
                    b.HasOne("WebScraper.Data.Models.Country", "Country")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WebScraper.Data.Models.User", b =>
                {
                    b.HasOne("WebScraper.Data.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Company", b =>
                {
                    b.Navigation("Freights");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebScraper.Data.Models.Country", b =>
                {
                    b.Navigation("Towns");
                });
#pragma warning restore 612, 618
        }
    }
}
