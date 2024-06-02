using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class Supplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
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
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 212, DateTimeKind.Local).AddTicks(9660), new Guid("869f2688-c88e-4f25-b3f2-b961262e5a6e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 212, DateTimeKind.Local).AddTicks(9794), new Guid("f823d7e6-c9d1-4db1-8b18-97d44d11e4da") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 212, DateTimeKind.Local).AddTicks(9838), new Guid("12dbbdea-39fc-46a5-96f8-0bb1b7f40f43") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(3539), new Guid("52904d11-acc3-45a6-ad6d-4e1cc95c29a8"), "Chicken", null, 2104.10m, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(3906), new Guid("cf0d9499-5c3e-4172-9fc4-dff539c5be10"), "Mouse", null, 3913.95m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4007), new Guid("87ac6908-c5de-4edf-a4e7-ee32eb0e4ea5"), "Pizza", null, 5002.12m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4077), new Guid("f5437bfd-51c1-47ea-8c88-313fa1ef3c56"), "Pants", null, 9362.32m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4141), new Guid("cf17e1a3-8968-48d5-8e64-32c135143e7f"), null, 5836.39m, (short)1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4262), new Guid("526fc88f-228d-44a2-ba59-a1e04a9f4c89"), "Hat", null, 8471.33m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4335), new Guid("5747927b-5689-4d8f-b4e5-ce55270161e4"), "Table", null, 4401.11m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4400), new Guid("b515740f-defc-4fc7-aa2d-9fb3b3b7764c"), "Keyboard", null, 858.54m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4463), new Guid("6ae96786-85c8-4f8b-92dd-7dd5960301bf"), "Keyboard", null, 3729.67m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4527), new Guid("32d7048d-4838-4f60-aed8-bbd583376634"), "Hat", null, 3849.77m, (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4596), new Guid("b53f4404-801e-4470-a858-b2f58942066a"), "Fish", null, 7203.78m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4706), new Guid("dd945c2a-5958-4dfe-ad3f-b73ffc42f3cb"), "Tuna", null, 806.98m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4769), new Guid("f737b3ed-466f-4613-9c67-c5072102d8dd"), "Chair", null, 5157.02m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4831), new Guid("0160569c-b103-403b-807d-8d6f31cd3caf"), null, 8055.49m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4892), new Guid("daba1fa2-23c4-4c37-99b4-9e7cd2609c17"), "Chicken", null, 2723.05m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(4952), new Guid("a38b48b9-bcdb-48e5-be3f-8fab19368450"), null, 5389.41m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5013), new Guid("7600c257-4386-4088-96b4-b4c2047e009c"), "Shoes", null, 8824.79m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5077), new Guid("d5099c8b-7d05-4f05-a263-a0f5a088c145"), null, 2995.34m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5145), new Guid("c651a1b3-4525-43c0-8d87-2370032abdfb"), "Computer", null, 3933.13m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "SupplierID", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(5251), new Guid("4824c118-29ec-44f5-933c-debb6438954c"), "Shoes", null, 1862.49m, (short)2 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(7630), "192.168.1.1", true, new Guid("92c5d904-e7b8-43c6-9d9a-a4d718809563"), null, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(7687), "192.168.1.1", true, new Guid("7136b69a-0160-412e-8bd8-76a90ed554ab"), null, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 16, 6, 21, 216, DateTimeKind.Local).AddTicks(7721), "192.168.1.1", true, new Guid("992b8665-87a9-4239-9b9d-6a3870c11056"), null, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 309, DateTimeKind.Local).AddTicks(9082), new Guid("52f44bc4-9bff-4fe5-9a5c-e081cf97b9cb") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 309, DateTimeKind.Local).AddTicks(9188), new Guid("65d2b191-fb84-47a3-9470-5ab3c3e16737") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 309, DateTimeKind.Local).AddTicks(9228), new Guid("fd8603fc-f92f-4b91-af3e-973e79b786d7") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(8671), new Guid("6a5de9af-638b-46c8-9220-b472ab7ce188"), "Mouse", 2843.75m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(8995), new Guid("b67144bf-d926-413b-8b45-a01809a9e479"), "Cheese", 7903.74m, (short)74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9075), new Guid("505422bd-0af5-4cc6-855c-9b5db4af6feb"), "Cheese", 8093.15m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9138), new Guid("21d6e10a-cd2e-4b97-b575-0dcce747aff5"), "Mouse", 7988.74m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9198), new Guid("15105847-4ece-4899-bf5c-53dd8d97a42e"), 8183.07m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9260), new Guid("f466199a-e000-49ad-97ac-75b64d114fa8"), "Chips", 5793.98m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9321), new Guid("568d8d56-1c33-4e7b-84fa-3315bb7940d4"), "Pizza", 6300.62m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9379), new Guid("ee84e84e-dd2f-44fd-8b01-1596d79fb8ad"), "Towels", 3617.52m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9456), new Guid("b7634fc8-169d-49ee-94af-29ac19c79269"), "Pants", 4226.89m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9567), new Guid("e60dbc2b-44d8-4c94-a0af-abc74c5d2b1c"), "Bacon", 5326.17m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9638), new Guid("a46381f0-f706-4f53-8965-d3511c022938"), "Pants", 4180.87m, (short)27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9700), new Guid("1b80601a-fabd-4989-8a99-1c61d2f2852d"), "Ball", 528.65m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9759), new Guid("721b5b1e-bad8-4114-a4c3-a39f3365a5ec"), "Keyboard", 5796.64m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9817), new Guid("af9f1731-a8cd-449e-a1d0-6fd582aeb814"), 7611.76m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9875), new Guid("790447eb-1d23-4fb6-b865-b08e3922fa36"), "Chips", 3442.53m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9933), new Guid("bb9c9590-34b7-47e7-9b22-66c1e789054e"), 2020.50m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9997), new Guid("f78c4fcb-31fd-4e14-886f-9b87c86dc39f"), "Chair", 5728.95m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 313, DateTimeKind.Local).AddTicks(60), new Guid("b43d9f93-486b-40f2-8a22-b4c4b0cca9f3"), 6720.63m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 313, DateTimeKind.Local).AddTicks(120), new Guid("ce316e4d-f681-49f6-b668-a839b94af1d8"), "Mouse", 1370.03m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 29, 11, 7, 26, 313, DateTimeKind.Local).AddTicks(178), new Guid("4e18aa82-3b76-440c-b798-63f2f259a3cb"), "Pizza", 3521.33m, (short)65 });
        }
    }
}
