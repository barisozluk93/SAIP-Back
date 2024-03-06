﻿// <auto-generated />
using FileManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FileManagement.Migrations
{
    [DbContext(typeof(FileManagementContext))]
    partial class FileManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FileManagement.Entity.File", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Length")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Files");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 14086m,
                            Name = "1",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\1.jpg"
                        },
                        new
                        {
                            Id = 2L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 12481m,
                            Name = "2",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\2.jpg"
                        },
                        new
                        {
                            Id = 3L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 8663m,
                            Name = "3",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\3.jpg"
                        },
                        new
                        {
                            Id = 4L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 20976m,
                            Name = "4",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\4.jpg"
                        },
                        new
                        {
                            Id = 5L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 11770m,
                            Name = "5",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\5.jpg"
                        },
                        new
                        {
                            Id = 6L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 13585m,
                            Name = "6",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\6.jpg"
                        },
                        new
                        {
                            Id = 7L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 15732m,
                            Name = "7",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\7.jpg"
                        },
                        new
                        {
                            Id = 8L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 19896m,
                            Name = "8",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\8.jpg"
                        },
                        new
                        {
                            Id = 9L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 13939m,
                            Name = "9",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\9.jpg"
                        },
                        new
                        {
                            Id = 10L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 12552m,
                            Name = "10",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\10.jpg"
                        },
                        new
                        {
                            Id = 11L,
                            ContentType = "image/jpg",
                            Extension = ".jpg",
                            IsDeleted = false,
                            Length = 20349m,
                            Name = "11",
                            Path = "C:\\Users\\Asus\\Documents\\GitHub\\SAIP-Back\\FileManagement\\Uploads\\11.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}