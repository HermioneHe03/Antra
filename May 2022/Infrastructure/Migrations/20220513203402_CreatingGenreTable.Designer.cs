﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MovieShopDbContext))]
    [Migration("20220513203402_CreatingGenreTable")]
    partial class CreatingGenreTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApplicationCore.Entities.Genre", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("nvarchar(64)");

                b.HasKey("Id");

                b.ToTable("Genre", (string)null);
            });

            modelBuilder.Entity("ApplicationCore.Entities.Movie", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("BackdropUrl")
                    .HasMaxLength(2084)
                    .HasColumnType("nvarchar(2084)");

                b.Property<decimal?>("Budget")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("CreatedBy")
                    .HasMaxLength(4096)
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("ImdbUrl")
                    .HasMaxLength(2084)
                    .HasColumnType("nvarchar(2084)");

                b.Property<string>("OriginalLanguage")
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("Overview")
                    .HasMaxLength(4096)
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PosterUrl")
                    .HasMaxLength(2084)
                    .HasColumnType("nvarchar(2084)");

                b.Property<decimal?>("Price")
                    .HasColumnType("decimal(18,2)");

                b.Property<DateTime?>("ReleaseDate")
                    .HasColumnType("datetime2");

                b.Property<decimal?>("Revenue")
                    .HasColumnType("decimal(18,2)");

                b.Property<int?>("RunTime")
                    .HasColumnType("int");

                b.Property<string>("Tagline")
                    .HasMaxLength(512)
                    .HasColumnType("nvarchar(512)");

                b.Property<string>("Title")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("TmdbUrl")
                    .HasMaxLength(2084)
                    .HasColumnType("nvarchar(2084)");

                b.Property<string>("UpdatedBy")
                    .HasMaxLength(4096)
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Movie");
            });
#pragma warning restore 612, 618
        }
    }
}
