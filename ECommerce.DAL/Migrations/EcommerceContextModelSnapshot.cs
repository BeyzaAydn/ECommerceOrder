﻿// <auto-generated />
using System;
using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 23, DateTimeKind.Local).AddTicks(9818),
                            CreatedIpAddress = "192.168.1.1",
                            Description = "Test Category 1 Description",
                            IsActive = true,
                            MasterId = new Guid("80d13ec4-95ca-432a-b6c8-87299cb7765f"),
                            Status = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Test Category 2",
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 23, DateTimeKind.Local).AddTicks(9915),
                            CreatedIpAddress = "192.168.1.1",
                            Description = "Test Category 2 Description",
                            IsActive = true,
                            MasterId = new Guid("15ada418-4d52-4677-994a-73b046817a03"),
                            Status = 0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Test Category 3",
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 23, DateTimeKind.Local).AddTicks(9921),
                            CreatedIpAddress = "192.168.1.1",
                            Description = "Test Category 3 Description",
                            IsActive = true,
                            MasterId = new Guid("64580a60-83d7-4ed6-8f79-c7921f87c821"),
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
                        .IsRequired()
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
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(819),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("5de9e0c1-c9f0-4818-ac87-bb0b5bdee120"),
                            ProductName = "Chicken",
                            Status = 0,
                            UnitPrice = 7754.05m,
                            UnitsInStock = (short)85,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 12,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1442),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("d7380f65-f3ad-42c3-9f2f-a61f1465ac1e"),
                            ProductName = "Chair",
                            Status = 0,
                            UnitPrice = 1787.65m,
                            UnitsInStock = (short)42,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 13,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1476),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("5151375d-e67a-4cb0-b8d9-41295461e427"),
                            ProductName = "Cheese",
                            Status = 0,
                            UnitPrice = 3281.43m,
                            UnitsInStock = (short)4,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 14,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1492),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("7fc9c61c-834a-4c54-8c28-3eca583cd78c"),
                            ProductName = "Pizza",
                            Status = 0,
                            UnitPrice = 3573.08m,
                            UnitsInStock = (short)25,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 15,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1507),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("7a9caec9-4ab3-445e-b238-df0794980f86"),
                            ProductName = "Bacon",
                            Status = 0,
                            UnitPrice = 1548.49m,
                            UnitsInStock = (short)54,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 16,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1524),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("88ee9c48-4fb5-4623-b28d-a7d9305019d4"),
                            ProductName = "Cheese",
                            Status = 0,
                            UnitPrice = 8045.58m,
                            UnitsInStock = (short)64,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 17,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1559),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("df3ac61d-5b0f-4fb0-84d9-897c8b8f669a"),
                            ProductName = "Car",
                            Status = 0,
                            UnitPrice = 6661.61m,
                            UnitsInStock = (short)17,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 18,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1575),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("98336ebb-5d6c-41a7-9e80-ca46aa6c425d"),
                            ProductName = "Pizza",
                            Status = 0,
                            UnitPrice = 9787.48m,
                            UnitsInStock = (short)40,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 19,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1589),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("bf8e0bea-36b0-4794-9b3b-2980e5453d0c"),
                            ProductName = "Salad",
                            Status = 0,
                            UnitPrice = 5660.95m,
                            UnitsInStock = (short)8,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 20,
                            CategoryId = 1,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1606),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("7fe09da0-939f-4f24-b529-1ada97183e85"),
                            ProductName = "Pants",
                            Status = 0,
                            UnitPrice = 6461.47m,
                            UnitsInStock = (short)17,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 21,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1622),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("46e42259-9823-4adc-b312-fb0a80347a4b"),
                            ProductName = "Shirt",
                            Status = 0,
                            UnitPrice = 3479.33m,
                            UnitsInStock = (short)45,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 22,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1637),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("79ca5f60-f734-4dd3-bc5f-3bba79d65931"),
                            ProductName = "Keyboard",
                            Status = 0,
                            UnitPrice = 5429.72m,
                            UnitsInStock = (short)59,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 23,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1650),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("c4242575-0e33-4fa0-9f3d-bde4153c263f"),
                            ProductName = "Shirt",
                            Status = 0,
                            UnitPrice = 126.14m,
                            UnitsInStock = (short)11,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 24,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1665),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("64cbbd9f-e4f2-41c6-adba-dc1c0cafbbe8"),
                            ProductName = "Chair",
                            Status = 0,
                            UnitPrice = 3826.31m,
                            UnitsInStock = (short)79,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 25,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1682),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("1379f015-188d-47f9-85d1-0c899da10082"),
                            ProductName = "Hat",
                            Status = 0,
                            UnitPrice = 6176.58m,
                            UnitsInStock = (short)40,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 26,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1697),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("1ad0f0bb-2b37-4d78-bcd6-4ba2696a2bf4"),
                            ProductName = "Bike",
                            Status = 0,
                            UnitPrice = 131.69m,
                            UnitsInStock = (short)38,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 27,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1723),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("a2487cdb-954b-47dc-97bf-c5cb7db9f3df"),
                            ProductName = "Towels",
                            Status = 0,
                            UnitPrice = 9719.46m,
                            UnitsInStock = (short)75,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 28,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1741),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("65f8c461-0b6a-4425-badd-58cfb5e01433"),
                            ProductName = "Cheese",
                            Status = 0,
                            UnitPrice = 8336.76m,
                            UnitsInStock = (short)82,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 29,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1756),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("95957036-bb0b-454f-b15b-24b06092cebc"),
                            ProductName = "Table",
                            Status = 0,
                            UnitPrice = 2305.50m,
                            UnitsInStock = (short)5,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 30,
                            CategoryId = 2,
                            CreatedComputerName = "DESKTOP-J4PTH70",
                            CreatedDate = new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1771),
                            CreatedIpAddress = "192.168.1.1",
                            ImagePath = "http://lorempixel.com/640/480/fashion",
                            IsActive = true,
                            MasterId = new Guid("0329746b-a08d-43b4-b285-946a87a1c635"),
                            ProductName = "Ball",
                            Status = 0,
                            UnitPrice = 5217.76m,
                            UnitsInStock = (short)98,
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
