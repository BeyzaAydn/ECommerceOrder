using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class ProductModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Category 1", "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(1862), "192.168.1.1", "Test Category 1 Description", true, new Guid("ddf5ae7d-b531-4e96-90eb-58c92c6471aa"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Test Category 2", "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(1993), "192.168.1.1", "Test Category 2 Description", true, new Guid("cc71c971-ed5d-4d45-85a3-ba1f4a77be16"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Test Category 3", "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(2003), "192.168.1.1", "Test Category 3 Description", true, new Guid("a64c80e8-c763-43bd-a392-6b403964dd18"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 11, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(3619), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("f22b1f3f-651a-4df8-a8b6-879f05a9f3d0"), "Cheese", 0, 6339.89m, (short)36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4107), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("cb70d563-a9bb-4e4f-a3f2-e358f2ab19e0"), "Pants", 0, 6618.79m, (short)52, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4144), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("5b27bded-d253-438d-ba4f-b3fa129b0544"), "Bacon", 0, 5296.96m, (short)64, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4168), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("1aa6bdd2-dda0-4727-96f9-03d016624ad4"), "Gloves", 0, 853.99m, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4190), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("9810b3e8-bb9c-4a78-b5f1-4fe764c3b1f5"), "Cheese", 0, 9599.72m, (short)18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4210), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("b5834427-b3ef-4200-a293-46acdddbd1f1"), "Soap", 0, 4683.54m, (short)19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4230), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("6dba9d1d-3a23-4dc3-9247-e71be6c7b634"), "Bacon", 0, 9762.02m, (short)65, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4250), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("ea376c92-b85c-4dbe-aa57-5d9f9fcc6f12"), "Cheese", 0, 3794.10m, (short)95, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4346), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("670758f4-3b44-4b10-ac18-53e5922fd8ac"), "Fish", 0, 5546.61m, (short)70, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4377), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("182f8bb8-8954-489c-8336-8691ad34b04b"), "Bike", 0, 7280.82m, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4398), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("8dc2a928-d1c3-4c79-bf4e-efcfe7b793bc"), "Pants", 0, 2987.97m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4416), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("0e7f5de6-6b72-4586-8e91-f95cec3cc1e0"), "Gloves", 0, 4080.14m, (short)78, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4434), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("32bcf353-9338-42db-a401-78e50076227a"), "Sausages", 0, 3119.74m, (short)40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4468), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("5de16e93-20a2-4d50-8a49-b6e1d6eaae98"), "Sausages", 0, 3578.49m, (short)32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4488), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("4e3ae8be-3d74-4c31-9d32-15c27c4b90c6"), "Pants", 0, 7217.53m, (short)35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4505), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("4d9a1ad3-675a-4dc7-94ce-c85f09cfdb23"), "Keyboard", 0, 1742.16m, (short)74, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4523), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("55661540-c3d6-4f46-bead-f4f464e1cd87"), "Table", 0, 7191.57m, (short)80, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4548), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("8eb1f989-f32d-4b21-acc3-f360d591c24c"), "Bacon", 0, 8970.45m, (short)4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4567), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("78de28b7-7d41-45b1-a2e1-c5980562200b"), "Keyboard", 0, 9655.49m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4583), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("e743f790-31b0-4747-b968-7fe2853f8258"), "Salad", 0, 4713.25m, (short)73, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
