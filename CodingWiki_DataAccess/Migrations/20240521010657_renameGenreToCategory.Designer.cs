﻿// <auto-generated />
using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240521010657_renameGenreToCategory")]
    partial class renameGenreToCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodingWiki_Model.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            ISBN = "1234A12",
                            Price = 10.99m,
                            Title = "The Owl House"
                        },
                        new
                        {
                            BookId = 2,
                            ISBN = "1853B43",
                            Price = 12.99m,
                            Title = "Tamen De Gushi"
                        },
                        new
                        {
                            BookId = 3,
                            ISBN = "5382C43",
                            Price = 15.99m,
                            Title = "Percy Jackson"
                        },
                        new
                        {
                            BookId = 4,
                            ISBN = "5345D52",
                            Price = 20.99m,
                            Title = "Avatar: The Last Airbender"
                        },
                        new
                        {
                            BookId = 5,
                            ISBN = "4146E68",
                            Price = 22.99m,
                            Title = "Spy X Family"
                        });
                });

            modelBuilder.Entity("CodingWiki_Model.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
