using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProductCategoryData : Migration
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1, "Test Category 1", "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 23, DateTimeKind.Local).AddTicks(9818), "192.168.1.1", "Test Category 1 Description", true, new Guid("80d13ec4-95ca-432a-b6c8-87299cb7765f"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Test Category 2", "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 23, DateTimeKind.Local).AddTicks(9915), "192.168.1.1", "Test Category 2 Description", true, new Guid("15ada418-4d52-4677-994a-73b046817a03"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Test Category 3", "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 23, DateTimeKind.Local).AddTicks(9921), "192.168.1.1", "Test Category 3 Description", true, new Guid("64580a60-83d7-4ed6-8f79-c7921f87c821"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 11, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(819), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("5de9e0c1-c9f0-4818-ac87-bb0b5bdee120"), "Chicken", 0, 7754.05m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1442), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("d7380f65-f3ad-42c3-9f2f-a61f1465ac1e"), "Chair", 0, 1787.65m, (short)42, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1476), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("5151375d-e67a-4cb0-b8d9-41295461e427"), "Cheese", 0, 3281.43m, (short)4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1492), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("7fc9c61c-834a-4c54-8c28-3eca583cd78c"), "Pizza", 0, 3573.08m, (short)25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1507), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("7a9caec9-4ab3-445e-b238-df0794980f86"), "Bacon", 0, 1548.49m, (short)54, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1524), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("88ee9c48-4fb5-4623-b28d-a7d9305019d4"), "Cheese", 0, 8045.58m, (short)64, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1559), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("df3ac61d-5b0f-4fb0-84d9-897c8b8f669a"), "Car", 0, 6661.61m, (short)17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1575), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("98336ebb-5d6c-41a7-9e80-ca46aa6c425d"), "Pizza", 0, 9787.48m, (short)40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1589), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("bf8e0bea-36b0-4794-9b3b-2980e5453d0c"), "Salad", 0, 5660.95m, (short)8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 1, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1606), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("7fe09da0-939f-4f24-b529-1ada97183e85"), "Pants", 0, 6461.47m, (short)17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1622), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("46e42259-9823-4adc-b312-fb0a80347a4b"), "Shirt", 0, 3479.33m, (short)45, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1637), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("79ca5f60-f734-4dd3-bc5f-3bba79d65931"), "Keyboard", 0, 5429.72m, (short)59, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1650), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("c4242575-0e33-4fa0-9f3d-bde4153c263f"), "Shirt", 0, 126.14m, (short)11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1665), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("64cbbd9f-e4f2-41c6-adba-dc1c0cafbbe8"), "Chair", 0, 3826.31m, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1682), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("1379f015-188d-47f9-85d1-0c899da10082"), "Hat", 0, 6176.58m, (short)40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1697), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("1ad0f0bb-2b37-4d78-bcd6-4ba2696a2bf4"), "Bike", 0, 131.69m, (short)38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1723), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("a2487cdb-954b-47dc-97bf-c5cb7db9f3df"), "Towels", 0, 9719.46m, (short)75, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1741), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("65f8c461-0b6a-4425-badd-58cfb5e01433"), "Cheese", 0, 8336.76m, (short)82, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1756), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("95957036-bb0b-454f-b15b-24b06092cebc"), "Table", 0, 2305.50m, (short)5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 2, "DESKTOP-J4PTH70", new DateTime(2024, 5, 21, 14, 33, 58, 26, DateTimeKind.Local).AddTicks(1771), "192.168.1.1", "http://lorempixel.com/640/480/fashion", true, new Guid("0329746b-a08d-43b4-b285-946a87a1c635"), "Ball", 0, 5217.76m, (short)98, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
