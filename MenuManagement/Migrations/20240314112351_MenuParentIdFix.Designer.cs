﻿// <auto-generated />
using System;
using MenuManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MenuManagement.Migrations
{
    [DbContext(typeof(MenuManagementContext))]
    [Migration("20240314112351_MenuParentIdFix")]
    partial class MenuParentIdFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MenuManagement.Entity.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSystemData")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Dashboard",
                            NameEn = "Dashboard",
                            PermissionId = 21L,
                            Url = "/dashboard"
                        },
                        new
                        {
                            Id = 2L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Kullanıcı Yönetimi",
                            NameEn = "User Management"
                        },
                        new
                        {
                            Id = 3L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Yetkiler",
                            NameEn = "Permissions",
                            ParentId = 2L,
                            PermissionId = 1L,
                            Url = "/usermanagement/permissions"
                        },
                        new
                        {
                            Id = 4L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Roller",
                            NameEn = "Roles",
                            ParentId = 2L,
                            PermissionId = 5L,
                            Url = "/usermanagement/roles"
                        },
                        new
                        {
                            Id = 5L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Kullanıcılar",
                            NameEn = "Users",
                            ParentId = 2L,
                            PermissionId = 13L,
                            Url = "/usermanagement/users"
                        },
                        new
                        {
                            Id = 6L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Organizasyon Yönetimi",
                            NameEn = "Organization Management",
                            PermissionId = 9L,
                            Url = "/organizationmanagement"
                        },
                        new
                        {
                            Id = 7L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Menü Yönetimi",
                            NameEn = "Menu Management",
                            PermissionId = 17L,
                            Url = "/menumanagement"
                        },
                        new
                        {
                            Id = 8L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Ürün Yönetimi",
                            NameEn = "Product Management",
                            PermissionId = 22L,
                            Url = "/productmanagement"
                        });
                });

            modelBuilder.Entity("MenuManagement.Entity.Menu", b =>
                {
                    b.HasOne("MenuManagement.Entity.Menu", "Parent")
                        .WithMany("ChildMenus")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("MenuManagement.Entity.Menu", b =>
                {
                    b.Navigation("ChildMenus");
                });
#pragma warning restore 612, 618
        }
    }
}
