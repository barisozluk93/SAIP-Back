﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UserManagement.DbContexts;

#nullable disable

namespace UserManagement.Migrations
{
    [DbContext(typeof(UserManagementContext))]
    partial class UserManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UserManagement.Entity.ApplicationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RefreshTokenExpireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("UserManagement.Entity.Organization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("UserManagement.Entity.OrganizationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("OrganizationId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("OrganizationUsers");
                });

            modelBuilder.Entity("UserManagement.Entity.Permission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSystemData")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "PermissionScene.Paging.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Yetki Ekranı Listeleme Yetkisi"
                        },
                        new
                        {
                            Id = 2L,
                            Code = "PermissionScene.Save.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Yetki Ekranı Kayıt Yetkisi"
                        },
                        new
                        {
                            Id = 3L,
                            Code = "PermissionScene.Edit.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Yetki Ekranı Güncelleme Yetkisi"
                        },
                        new
                        {
                            Id = 4L,
                            Code = "PermissionScene.Delete.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Yetki Ekranı Silme Yetkisi"
                        },
                        new
                        {
                            Id = 5L,
                            Code = "RoleScene.Paging.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Rol Ekranı Listeleme Yetkisi"
                        },
                        new
                        {
                            Id = 6L,
                            Code = "RoleScene.Save.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Rol Ekranı Kayıt Yetkisi"
                        },
                        new
                        {
                            Id = 7L,
                            Code = "RoleScene.Edit.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Rol Ekranı Güncelleme Yetkisi"
                        },
                        new
                        {
                            Id = 8L,
                            Code = "RoleScene.Delete.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Rol Ekranı Silme Yetkisi"
                        },
                        new
                        {
                            Id = 9L,
                            Code = "OrganizationScene.Paging.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Organizasyon Ekranı Listeleme Yetkisi"
                        },
                        new
                        {
                            Id = 10L,
                            Code = "OrganizationScene.Save.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Organizasyon Ekranı Kayıt Yetkisi"
                        },
                        new
                        {
                            Id = 11L,
                            Code = "OrganizationScene.Edit.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Organizasyon Ekranı Güncelleme Yetkisi"
                        },
                        new
                        {
                            Id = 12L,
                            Code = "OrganizationScene.Delete.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Organizasyon Ekranı Silme Yetkisi"
                        },
                        new
                        {
                            Id = 13L,
                            Code = "UserScene.Paging.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Kullanıcı Ekranı Listeleme Yetkisi"
                        },
                        new
                        {
                            Id = 14L,
                            Code = "UserScene.Save.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Kullanıcı Ekranı Kayıt Yetkisi"
                        },
                        new
                        {
                            Id = 15L,
                            Code = "UserScene.Edit.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Kullanıcı Ekranı Güncelleme Yetkisi"
                        },
                        new
                        {
                            Id = 16L,
                            Code = "UserScene.Delete.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Kullanıcı Ekranı Silme Yetkisi"
                        },
                        new
                        {
                            Id = 17L,
                            Code = "MenuScene.List.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Menü Ekranı Listeleme Yetkisi"
                        },
                        new
                        {
                            Id = 18L,
                            Code = "MenuScene.Save.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Menü Ekranı Kayıt Yetkisi"
                        },
                        new
                        {
                            Id = 19L,
                            Code = "MenuScene.Edit.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Menü Ekranı Güncelleme Yetkisi"
                        },
                        new
                        {
                            Id = 20L,
                            Code = "MenuScene.Delete.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Menü Ekranı Silme Yetkisi"
                        },
                        new
                        {
                            Id = 21L,
                            Code = "DashboardScene.View.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Dashboard Görüntüleme Yetkisi"
                        },
                        new
                        {
                            Id = 22L,
                            Code = "MapScene.View.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Harita Görüntüleme Yetkisi"
                        },
                        new
                        {
                            Id = 23L,
                            Code = "ProductScene.List.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Ürün Ekranı Listeleme Yetkisi"
                        },
                        new
                        {
                            Id = 24L,
                            Code = "ProductScene.Save.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Ürün Ekranı Kayıt Yetkisi"
                        },
                        new
                        {
                            Id = 25L,
                            Code = "ProductScene.Edit.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Ürün Ekranı Güncelleme Yetkisi"
                        },
                        new
                        {
                            Id = 26L,
                            Code = "ProductScene.Delete.Permission",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "Ürün Ekranı Silme Yetkisi"
                        });
                });

            modelBuilder.Entity("UserManagement.Entity.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSystemData")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "SuperAdmin"
                        },
                        new
                        {
                            Id = 2L,
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "ExternalUser"
                        });
                });

            modelBuilder.Entity("UserManagement.Entity.RolePermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            PermissionId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            IsDeleted = false,
                            PermissionId = 2L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            IsDeleted = false,
                            PermissionId = 3L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            IsDeleted = false,
                            PermissionId = 4L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            IsDeleted = false,
                            PermissionId = 5L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 6L,
                            IsDeleted = false,
                            PermissionId = 6L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            IsDeleted = false,
                            PermissionId = 7L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 8L,
                            IsDeleted = false,
                            PermissionId = 8L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 9L,
                            IsDeleted = false,
                            PermissionId = 9L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 10L,
                            IsDeleted = false,
                            PermissionId = 10L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 11L,
                            IsDeleted = false,
                            PermissionId = 11L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 12L,
                            IsDeleted = false,
                            PermissionId = 12L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 13L,
                            IsDeleted = false,
                            PermissionId = 13L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 14L,
                            IsDeleted = false,
                            PermissionId = 14L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 15L,
                            IsDeleted = false,
                            PermissionId = 15L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 16L,
                            IsDeleted = false,
                            PermissionId = 16L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 17L,
                            IsDeleted = false,
                            PermissionId = 17L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 18L,
                            IsDeleted = false,
                            PermissionId = 18L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 19L,
                            IsDeleted = false,
                            PermissionId = 19L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 20L,
                            IsDeleted = false,
                            PermissionId = 20L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 21L,
                            IsDeleted = false,
                            PermissionId = 21L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 22L,
                            IsDeleted = false,
                            PermissionId = 22L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 23L,
                            IsDeleted = false,
                            PermissionId = 23L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 24L,
                            IsDeleted = false,
                            PermissionId = 24L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 25L,
                            IsDeleted = false,
                            PermissionId = 25L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 26L,
                            IsDeleted = false,
                            PermissionId = 26L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 27L,
                            IsDeleted = false,
                            PermissionId = 21L,
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 28L,
                            IsDeleted = false,
                            PermissionId = 22L,
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 29L,
                            IsDeleted = false,
                            PermissionId = 23L,
                            RoleId = 2L
                        });
                });

            modelBuilder.Entity("UserManagement.Entity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSystemData")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("bytea");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "super@test.com",
                            IsDeleted = false,
                            IsSystemData = true,
                            Name = "SuperAdmin",
                            Password = "DBD9DCE9DB51E56E1468B18F44233EB1FF625ADCECAAE2D7E9776BC714AF69D2A360B57CDB7C4E098C6225543BF83C50DAEC23A8DAADF9212BADF6F26760911C",
                            Phone = "+905077352772",
                            Salt = new byte[] { 3, 251, 182, 108, 1, 165, 5, 95, 117, 7, 42, 45, 196, 160, 190, 194, 65, 169, 48, 49, 99, 22, 120, 177, 165, 246, 57, 186, 94, 216, 59, 80, 48, 229, 210, 31, 5, 173, 219, 134, 83, 73, 90, 196, 220, 216, 163, 14, 219, 106, 52, 183, 13, 250, 15, 143, 154, 208, 85, 45, 29, 52, 13, 105 },
                            Surname = "SuperAdmin",
                            Username = "superadmin"
                        });
                });

            modelBuilder.Entity("UserManagement.Entity.UserPermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            PermissionId = 1L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            IsDeleted = false,
                            PermissionId = 2L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            IsDeleted = false,
                            PermissionId = 3L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            IsDeleted = false,
                            PermissionId = 4L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            IsDeleted = false,
                            PermissionId = 5L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 6L,
                            IsDeleted = false,
                            PermissionId = 6L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            IsDeleted = false,
                            PermissionId = 7L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 8L,
                            IsDeleted = false,
                            PermissionId = 8L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 9L,
                            IsDeleted = false,
                            PermissionId = 9L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 10L,
                            IsDeleted = false,
                            PermissionId = 10L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 11L,
                            IsDeleted = false,
                            PermissionId = 11L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 12L,
                            IsDeleted = false,
                            PermissionId = 12L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 13L,
                            IsDeleted = false,
                            PermissionId = 13L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 14L,
                            IsDeleted = false,
                            PermissionId = 14L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 15L,
                            IsDeleted = false,
                            PermissionId = 15L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 16L,
                            IsDeleted = false,
                            PermissionId = 16L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 17L,
                            IsDeleted = false,
                            PermissionId = 17L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 18L,
                            IsDeleted = false,
                            PermissionId = 18L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 19L,
                            IsDeleted = false,
                            PermissionId = 19L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 20L,
                            IsDeleted = false,
                            PermissionId = 20L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 21L,
                            IsDeleted = false,
                            PermissionId = 21L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 22L,
                            IsDeleted = false,
                            PermissionId = 22L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 23L,
                            IsDeleted = false,
                            PermissionId = 23L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 24L,
                            IsDeleted = false,
                            PermissionId = 24L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 25L,
                            IsDeleted = false,
                            PermissionId = 25L,
                            UserId = 1L
                        },
                        new
                        {
                            Id = 26L,
                            IsDeleted = false,
                            PermissionId = 26L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("UserManagement.Entity.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            RoleId = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("UserManagement.Entity.ApplicationUser", b =>
                {
                    b.HasOne("UserManagement.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserManagement.Entity.Organization", b =>
                {
                    b.HasOne("UserManagement.Entity.Organization", "ParentOrganization")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentOrganization");
                });

            modelBuilder.Entity("UserManagement.Entity.OrganizationUser", b =>
                {
                    b.HasOne("UserManagement.Entity.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserManagement.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserManagement.Entity.RolePermission", b =>
                {
                    b.HasOne("UserManagement.Entity.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserManagement.Entity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("UserManagement.Entity.UserPermission", b =>
                {
                    b.HasOne("UserManagement.Entity.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserManagement.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserManagement.Entity.UserRole", b =>
                {
                    b.HasOne("UserManagement.Entity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserManagement.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
