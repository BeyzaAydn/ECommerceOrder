﻿// <auto-generated />
using System;
using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20240527090805_ProductModelUpdate")]
    partial class ProductModelUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerce.Model.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ECommerce.Model.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("ECommerce.Model.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Test Category 1",
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(1862),
                            CreatedIpAddress = "192.168.1.1",
                            Description = "Test Category 1 Description",
                            IsActive = true,
                            MasterId = new Guid("ddf5ae7d-b531-4e96-90eb-58c92c6471aa"),
                            Status = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Test Category 2",
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(1993),
                            CreatedIpAddress = "192.168.1.1",
                            Description = "Test Category 2 Description",
                            IsActive = true,
                            MasterId = new Guid("cc71c971-ed5d-4d45-85a3-ba1f4a77be16"),
                            Status = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Test Category 3",
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(2003),
                            CreatedIpAddress = "192.168.1.1",
                            Description = "Test Category 3 Description",
                            IsActive = true,
                            MasterId = new Guid("a64c80e8-c763-43bd-a392-6b403964dd18"),
                            Status = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ECommerce.Model.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 11,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(3619),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("f22b1f3f-651a-4df8-a8b6-879f05a9f3d0"),
                            ProductName = "Cheese",
                            Status = 0,
                            UnitPrice = 6339.89m,
                            UnitsInStock = (short)36,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 12,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4107),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("cb70d563-a9bb-4e4f-a3f2-e358f2ab19e0"),
                            ProductName = "Pants",
                            Status = 0,
                            UnitPrice = 6618.79m,
                            UnitsInStock = (short)52,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 13,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4144),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("5b27bded-d253-438d-ba4f-b3fa129b0544"),
                            ProductName = "Bacon",
                            Status = 0,
                            UnitPrice = 5296.96m,
                            UnitsInStock = (short)64,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 14,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4168),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("1aa6bdd2-dda0-4727-96f9-03d016624ad4"),
                            ProductName = "Gloves",
                            Status = 0,
                            UnitPrice = 853.99m,
                            UnitsInStock = (short)79,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 15,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4190),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("9810b3e8-bb9c-4a78-b5f1-4fe764c3b1f5"),
                            ProductName = "Cheese",
                            Status = 0,
                            UnitPrice = 9599.72m,
                            UnitsInStock = (short)18,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 16,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4210),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("b5834427-b3ef-4200-a293-46acdddbd1f1"),
                            ProductName = "Soap",
                            Status = 0,
                            UnitPrice = 4683.54m,
                            UnitsInStock = (short)19,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 17,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4230),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("6dba9d1d-3a23-4dc3-9247-e71be6c7b634"),
                            ProductName = "Bacon",
                            Status = 0,
                            UnitPrice = 9762.02m,
                            UnitsInStock = (short)65,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 18,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4250),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("ea376c92-b85c-4dbe-aa57-5d9f9fcc6f12"),
                            ProductName = "Cheese",
                            Status = 0,
                            UnitPrice = 3794.10m,
                            UnitsInStock = (short)95,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 19,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4346),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("670758f4-3b44-4b10-ac18-53e5922fd8ac"),
                            ProductName = "Fish",
                            Status = 0,
                            UnitPrice = 5546.61m,
                            UnitsInStock = (short)70,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 20,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4377),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("182f8bb8-8954-489c-8336-8691ad34b04b"),
                            ProductName = "Bike",
                            Status = 0,
                            UnitPrice = 7280.82m,
                            UnitsInStock = (short)79,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 21,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4398),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("8dc2a928-d1c3-4c79-bf4e-efcfe7b793bc"),
                            ProductName = "Pants",
                            Status = 0,
                            UnitPrice = 2987.97m,
                            UnitsInStock = (short)85,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 22,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4416),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("0e7f5de6-6b72-4586-8e91-f95cec3cc1e0"),
                            ProductName = "Gloves",
                            Status = 0,
                            UnitPrice = 4080.14m,
                            UnitsInStock = (short)78,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 23,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4434),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("32bcf353-9338-42db-a401-78e50076227a"),
                            ProductName = "Sausages",
                            Status = 0,
                            UnitPrice = 3119.74m,
                            UnitsInStock = (short)40,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 24,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4468),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("5de16e93-20a2-4d50-8a49-b6e1d6eaae98"),
                            ProductName = "Sausages",
                            Status = 0,
                            UnitPrice = 3578.49m,
                            UnitsInStock = (short)32,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 25,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4488),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("4e3ae8be-3d74-4c31-9d32-15c27c4b90c6"),
                            ProductName = "Pants",
                            Status = 0,
                            UnitPrice = 7217.53m,
                            UnitsInStock = (short)35,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 26,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4505),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("4d9a1ad3-675a-4dc7-94ce-c85f09cfdb23"),
                            ProductName = "Keyboard",
                            Status = 0,
                            UnitPrice = 1742.16m,
                            UnitsInStock = (short)74,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 27,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4523),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("55661540-c3d6-4f46-bead-f4f464e1cd87"),
                            ProductName = "Table",
                            Status = 0,
                            UnitPrice = 7191.57m,
                            UnitsInStock = (short)80,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 28,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4548),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("8eb1f989-f32d-4b21-acc3-f360d591c24c"),
                            ProductName = "Bacon",
                            Status = 0,
                            UnitPrice = 8970.45m,
                            UnitsInStock = (short)4,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 29,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4567),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("78de28b7-7d41-45b1-a2e1-c5980562200b"),
                            ProductName = "Keyboard",
                            Status = 0,
                            UnitPrice = 9655.49m,
                            UnitsInStock = (short)85,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 30,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4583),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("e743f790-31b0-4747-b968-7fe2853f8258"),
                            ProductName = "Salad",
                            Status = 0,
                            UnitPrice = 4713.25m,
                            UnitsInStock = (short)73,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ECommerce.Model.Entities.Product", b =>
                {
                    b.HasOne("ECommerce.Model.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ECommerce.Model.Entities.AppUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ECommerce.Model.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ECommerce.Model.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ECommerce.Model.Entities.AppUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Model.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ECommerce.Model.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Model.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
