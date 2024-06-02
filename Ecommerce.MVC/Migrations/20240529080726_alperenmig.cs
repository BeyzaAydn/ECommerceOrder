using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class alperenmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 309, DateTimeKind.Local).AddTicks(9082), new Guid("52f44bc4-9bff-4fe5-9a5c-e081cf97b9cb") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 309, DateTimeKind.Local).AddTicks(9188), new Guid("65d2b191-fb84-47a3-9470-5ab3c3e16737") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 309, DateTimeKind.Local).AddTicks(9228), new Guid("fd8603fc-f92f-4b91-af3e-973e79b786d7") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(8671), new Guid("6a5de9af-638b-46c8-9220-b472ab7ce188"), 2843.75m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(8995), new Guid("b67144bf-d926-413b-8b45-a01809a9e479"), "Cheese", 7903.74m, (short)74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9075), new Guid("505422bd-0af5-4cc6-855c-9b5db4af6feb"), "Cheese", 8093.15m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9138), new Guid("21d6e10a-cd2e-4b97-b575-0dcce747aff5"), "Mouse", 7988.74m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9198), new Guid("15105847-4ece-4899-bf5c-53dd8d97a42e"), "Mouse", 8183.07m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9260), new Guid("f466199a-e000-49ad-97ac-75b64d114fa8"), "Chips", 5793.98m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9321), new Guid("568d8d56-1c33-4e7b-84fa-3315bb7940d4"), "Pizza", 6300.62m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9379), new Guid("ee84e84e-dd2f-44fd-8b01-1596d79fb8ad"), "Towels", 3617.52m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9456), new Guid("b7634fc8-169d-49ee-94af-29ac19c79269"), "Pants", 4226.89m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9567), new Guid("e60dbc2b-44d8-4c94-a0af-abc74c5d2b1c"), "Bacon", 5326.17m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9638), new Guid("a46381f0-f706-4f53-8965-d3511c022938"), "Pants", 4180.87m, (short)27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9700), new Guid("1b80601a-fabd-4989-8a99-1c61d2f2852d"), "Ball", 528.65m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9759), new Guid("721b5b1e-bad8-4114-a4c3-a39f3365a5ec"), 5796.64m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9817), new Guid("af9f1731-a8cd-449e-a1d0-6fd582aeb814"), "Bike", 7611.76m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9875), new Guid("790447eb-1d23-4fb6-b865-b08e3922fa36"), "Chips", 3442.53m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9933), new Guid("bb9c9590-34b7-47e7-9b22-66c1e789054e"), "Table", 2020.50m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 312, DateTimeKind.Local).AddTicks(9997), new Guid("f78c4fcb-31fd-4e14-886f-9b87c86dc39f"), 5728.95m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 313, DateTimeKind.Local).AddTicks(60), new Guid("b43d9f93-486b-40f2-8a22-b4c4b0cca9f3"), "Table", 6720.63m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 313, DateTimeKind.Local).AddTicks(120), new Guid("ce316e4d-f681-49f6-b668-a839b94af1d8"), "Mouse", 1370.03m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 11, 7, 26, 313, DateTimeKind.Local).AddTicks(178), new Guid("4e18aa82-3b76-440c-b798-63f2f259a3cb"), 3521.33m, (short)65 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 682, DateTimeKind.Local).AddTicks(1585), new Guid("75eab92c-3e2c-4af2-99ba-a1c04eaa9273") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 682, DateTimeKind.Local).AddTicks(1660), new Guid("e18185cb-a482-4d7c-8078-b62187603e72") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 682, DateTimeKind.Local).AddTicks(1665), new Guid("84c30ff7-f3e6-4dcf-b30a-a16fa5b45461") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9297), new Guid("576f8323-2044-481e-ab3c-68ab81ab14bb"), 5969.57m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9571), new Guid("a0c699af-2320-4d61-91ca-c7639e762087"), "Pants", 5762.29m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9601), new Guid("7348272f-2ba1-4c0c-b2c0-9744d0145491"), "Keyboard", 9198.70m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9617), new Guid("177219c8-5a3d-4f67-b784-8328c90a855f"), "Car", 323.21m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9631), new Guid("eeb31c4f-c21e-4bc8-8f7d-44cb41fe9302"), "Towels", 1452.02m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9645), new Guid("6215029f-6523-4153-8afb-9dd4748a7a73"), "Soap", 5998.39m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9659), new Guid("891a9d53-7005-4f8c-b657-4f72a84e7c85"), "Shirt", 115.00m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9718), new Guid("dc205ded-be3a-410c-b0a2-2520dd7aa034"), "Shirt", 3979.72m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9737), new Guid("930a0b5c-a884-47ad-a476-32b1ce456979"), "Pizza", 6520.00m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9751), new Guid("cbb5114d-fd16-40b7-a614-3c7ff4380187"), "Salad", 6583.24m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9770), new Guid("4aa3a504-5cd4-44c4-9e2e-616e335a9d85"), "Towels", 5178.51m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9783), new Guid("442c4a91-f31b-474a-8d70-41e08dc35fe5"), "Chicken", 8055.46m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9795), new Guid("e7b129c5-c7ab-4b00-b57d-46709612c0a4"), 6989.59m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9807), new Guid("90601d8e-e4b4-45f7-bb60-1684e2c6d789"), "Mouse", 7342.40m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9818), new Guid("e9dfc256-d276-4b01-a863-afae1c012dc8"), "Chair", 5141.12m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9831), new Guid("90226cf9-f871-41a8-96e0-4015fcb48fa0"), "Hat", 2516.53m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9843), new Guid("54465921-1b4f-4e9b-aa6e-9ed3ef17f958"), 2052.94m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9857), new Guid("07928453-ff15-407c-b874-af8eb24f07fd"), "Towels", 4277.02m, (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9872), new Guid("31ccb854-44c8-4718-abbf-60939d210271"), "Salad", 9682.63m, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedComputerName", "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-J4PTH70", new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9884), new Guid("f6f51abf-cede-41df-a815-10a062758f4f"), 4525.22m, (short)42 });
        }
    }
}
