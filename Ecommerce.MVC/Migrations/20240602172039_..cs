using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class _ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Freight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShipRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 832, DateTimeKind.Local).AddTicks(8275), new Guid("66143988-71bf-4d75-b1ec-e38da02ab6af") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 832, DateTimeKind.Local).AddTicks(8370), new Guid("022f3bc0-c4c0-4755-8552-a507e72dd0c3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 832, DateTimeKind.Local).AddTicks(8375), new Guid("bba040e2-06f9-4404-bb6b-758aed194ea0") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6368), new Guid("80db8dad-5155-446b-97fa-7acf9f45bf96"), "Towels", 2338.48m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6679), new Guid("af75804e-478c-4c41-86f9-cdfe32dd5ffb"), "Gloves", 7490.83m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6698), new Guid("ca67ff89-f93c-46a7-a2d6-0d0d1964cb2a"), "Bike", 981.21m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6710), new Guid("ff4bf913-99e6-4926-9da2-40f3118083d5"), "Towels", 2064.94m, (short)100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6733), new Guid("85aac792-d95c-45bb-9365-0d4c39844e89"), "Bacon", 3466.76m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6746), new Guid("b7367c95-dcd7-4168-b26d-7e91c2a2a5ff"), "Chips", 2977.68m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6757), new Guid("a0985182-03a9-4591-84a4-cc66cb28063c"), "Tuna", 8116.65m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6768), new Guid("a949afcc-7ded-403b-b0ee-8faba48de333"), "Cheese", 4221.14m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6777), new Guid("380afd28-0019-4430-9e61-d3f815c19486"), "Bacon", 6264.78m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6787), new Guid("4acf40e0-f0b7-4217-81b0-504f01d6385e"), "Tuna", 771.29m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6798), new Guid("dafe521b-97f5-4cfa-9f4a-a5f3185c0673"), "Table", 4734.55m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6864), new Guid("e93586e6-2e00-4cc6-a14b-5b8ff11361a8"), "Shirt", 2173.97m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6879), new Guid("6567a8bc-62a8-4edd-bb69-490e347167b3"), "Chips", 5374.39m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6889), new Guid("07f7e4b5-d5a2-4bd9-8767-516a197c4bb8"), "Chips", 4021.23m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6899), new Guid("a72c9e78-5e93-4047-8bbe-b856c17fe2c8"), "Pizza", 5286.87m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6910), new Guid("340bc6fd-e34b-4c2e-b16c-90f85dc3d846"), "Shoes", 5358.42m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6920), new Guid("7e505c07-6677-4663-9a34-efa873f5757e"), "Chair", 1186.83m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6932), new Guid("021b374b-4a8e-4b1b-9c63-8523cec7e102"), "Shirt", 4800.09m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6943), new Guid("8a408e5b-23a8-476c-b3d7-0aa340674313"), "Soap", 5216.03m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6954), new Guid("a54b0b3c-964d-4edc-994b-41880e48e98d"), "Pizza", 6372.47m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(8621), new Guid("c8456bde-4369-449d-85b8-43e4ac44ab71") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(8637), new Guid("f3b42ff8-d628-4276-8b67-efb33f287542") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "BEYZA", new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(8641), new Guid("73730707-72c0-45b9-95e3-5573f9839200") });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 212, DateTimeKind.Local).AddTicks(9660), new Guid("869f2688-c88e-4f25-b3f2-b961262e5a6e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 212, DateTimeKind.Local).AddTicks(9794), new Guid("f823d7e6-c9d1-4db1-8b18-97d44d11e4da") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 212, DateTimeKind.Local).AddTicks(9838), new Guid("12dbbdea-39fc-46a5-96f8-0bb1b7f40f43") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(3539), new Guid("52904d11-acc3-45a6-ad6d-4e1cc95c29a8"), "Chicken", 2104.10m, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(3906), new Guid("cf0d9499-5c3e-4172-9fc4-dff539c5be10"), "Mouse", 3913.95m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4007), new Guid("87ac6908-c5de-4edf-a4e7-ee32eb0e4ea5"), "Pizza", 5002.12m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4077), new Guid("f5437bfd-51c1-47ea-8c88-313fa1ef3c56"), "Pants", 9362.32m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4141), new Guid("cf17e1a3-8968-48d5-8e64-32c135143e7f"), "Mouse", 5836.39m, (short)1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4262), new Guid("526fc88f-228d-44a2-ba59-a1e04a9f4c89"), "Hat", 8471.33m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4335), new Guid("5747927b-5689-4d8f-b4e5-ce55270161e4"), "Table", 4401.11m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4400), new Guid("b515740f-defc-4fc7-aa2d-9fb3b3b7764c"), "Keyboard", 858.54m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4463), new Guid("6ae96786-85c8-4f8b-92dd-7dd5960301bf"), "Keyboard", 3729.67m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4527), new Guid("32d7048d-4838-4f60-aed8-bbd583376634"), "Hat", 3849.77m, (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4596), new Guid("b53f4404-801e-4470-a858-b2f58942066a"), "Fish", 7203.78m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4706), new Guid("dd945c2a-5958-4dfe-ad3f-b73ffc42f3cb"), "Tuna", 806.98m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4769), new Guid("f737b3ed-466f-4613-9c67-c5072102d8dd"), "Chair", 5157.02m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4831), new Guid("0160569c-b103-403b-807d-8d6f31cd3caf"), "Bike", 8055.49m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4892), new Guid("daba1fa2-23c4-4c37-99b4-9e7cd2609c17"), "Chicken", 2723.05m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4952), new Guid("a38b48b9-bcdb-48e5-be3f-8fab19368450"), "Table", 5389.41m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5013), new Guid("7600c257-4386-4088-96b4-b4c2047e009c"), "Shoes", 8824.79m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5077), new Guid("d5099c8b-7d05-4f05-a263-a0f5a088c145"), "Table", 2995.34m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5145), new Guid("c651a1b3-4525-43c0-8d87-2370032abdfb"), "Computer", 3933.13m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5251), new Guid("4824c118-29ec-44f5-933c-debb6438954c"), "Shoes", 1862.49m, (short)2 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(7630), new Guid("92c5d904-e7b8-43c6-9d9a-a4d718809563") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(7687), new Guid("7136b69a-0160-412e-8bd8-76a90ed554ab") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(7721), new Guid("992b8665-87a9-4239-9b9d-6a3870c11056") });
        }
    }
}
