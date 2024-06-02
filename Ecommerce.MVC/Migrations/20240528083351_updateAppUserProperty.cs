using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updateAppUserProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 682, DateTimeKind.Local).AddTicks(1585), new Guid("75eab92c-3e2c-4af2-99ba-a1c04eaa9273") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 682, DateTimeKind.Local).AddTicks(1660), new Guid("e18185cb-a482-4d7c-8078-b62187603e72") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 682, DateTimeKind.Local).AddTicks(1665), new Guid("84c30ff7-f3e6-4dcf-b30a-a16fa5b45461") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9297), new Guid("576f8323-2044-481e-ab3c-68ab81ab14bb"), "Mouse", 5969.57m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9571), new Guid("a0c699af-2320-4d61-91ca-c7639e762087"), 5762.29m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9601), new Guid("7348272f-2ba1-4c0c-b2c0-9744d0145491"), "Keyboard", 9198.70m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9617), new Guid("177219c8-5a3d-4f67-b784-8328c90a855f"), "Car", 323.21m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9631), new Guid("eeb31c4f-c21e-4bc8-8f7d-44cb41fe9302"), "Towels", 1452.02m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9645), new Guid("6215029f-6523-4153-8afb-9dd4748a7a73"), 5998.39m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9659), new Guid("891a9d53-7005-4f8c-b657-4f72a84e7c85"), "Shirt", 115.00m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9718), new Guid("dc205ded-be3a-410c-b0a2-2520dd7aa034"), "Shirt", 3979.72m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9737), new Guid("930a0b5c-a884-47ad-a476-32b1ce456979"), "Pizza", 6520.00m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9751), new Guid("cbb5114d-fd16-40b7-a614-3c7ff4380187"), "Salad", 6583.24m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9770), new Guid("4aa3a504-5cd4-44c4-9e2e-616e335a9d85"), "Towels", 5178.51m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9783), new Guid("442c4a91-f31b-474a-8d70-41e08dc35fe5"), "Chicken", 8055.46m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9795), new Guid("e7b129c5-c7ab-4b00-b57d-46709612c0a4"), "Keyboard", 6989.59m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9807), new Guid("90601d8e-e4b4-45f7-bb60-1684e2c6d789"), "Mouse", 7342.40m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9818), new Guid("e9dfc256-d276-4b01-a863-afae1c012dc8"), "Chair", 5141.12m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9831), new Guid("90226cf9-f871-41a8-96e0-4015fcb48fa0"), "Hat", 2516.53m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9843), new Guid("54465921-1b4f-4e9b-aa6e-9ed3ef17f958"), "Chair", 2052.94m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9857), new Guid("07928453-ff15-407c-b874-af8eb24f07fd"), "Towels", 4277.02m, (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9872), new Guid("31ccb854-44c8-4718-abbf-60939d210271"), "Salad", 9682.63m, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 33, 51, 684, DateTimeKind.Local).AddTicks(9884), new Guid("f6f51abf-cede-41df-a815-10a062758f4f"), "Pizza", 4525.22m, (short)42 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(1862), new Guid("ddf5ae7d-b531-4e96-90eb-58c92c6471aa") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(1993), new Guid("cc71c971-ed5d-4d45-85a3-ba1f4a77be16") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 732, DateTimeKind.Local).AddTicks(2003), new Guid("a64c80e8-c763-43bd-a392-6b403964dd18") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(3619), new Guid("f22b1f3f-651a-4df8-a8b6-879f05a9f3d0"), "Cheese", 6339.89m, (short)36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4107), new Guid("cb70d563-a9bb-4e4f-a3f2-e358f2ab19e0"), 6618.79m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4144), new Guid("5b27bded-d253-438d-ba4f-b3fa129b0544"), "Bacon", 5296.96m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4168), new Guid("1aa6bdd2-dda0-4727-96f9-03d016624ad4"), "Gloves", 853.99m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4190), new Guid("9810b3e8-bb9c-4a78-b5f1-4fe764c3b1f5"), "Cheese", 9599.72m, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4210), new Guid("b5834427-b3ef-4200-a293-46acdddbd1f1"), 4683.54m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4230), new Guid("6dba9d1d-3a23-4dc3-9247-e71be6c7b634"), "Bacon", 9762.02m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4250), new Guid("ea376c92-b85c-4dbe-aa57-5d9f9fcc6f12"), "Cheese", 3794.10m, (short)95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4346), new Guid("670758f4-3b44-4b10-ac18-53e5922fd8ac"), "Fish", 5546.61m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4377), new Guid("182f8bb8-8954-489c-8336-8691ad34b04b"), "Bike", 7280.82m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4398), new Guid("8dc2a928-d1c3-4c79-bf4e-efcfe7b793bc"), "Pants", 2987.97m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4416), new Guid("0e7f5de6-6b72-4586-8e91-f95cec3cc1e0"), "Gloves", 4080.14m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4434), new Guid("32bcf353-9338-42db-a401-78e50076227a"), "Sausages", 3119.74m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4468), new Guid("5de16e93-20a2-4d50-8a49-b6e1d6eaae98"), "Sausages", 3578.49m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4488), new Guid("4e3ae8be-3d74-4c31-9d32-15c27c4b90c6"), "Pants", 7217.53m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4505), new Guid("4d9a1ad3-675a-4dc7-94ce-c85f09cfdb23"), "Keyboard", 1742.16m, (short)74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4523), new Guid("55661540-c3d6-4f46-bead-f4f464e1cd87"), "Table", 7191.57m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4548), new Guid("8eb1f989-f32d-4b21-acc3-f360d591c24c"), "Bacon", 8970.45m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4567), new Guid("78de28b7-7d41-45b1-a2e1-c5980562200b"), "Keyboard", 9655.49m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 8, 5, 739, DateTimeKind.Local).AddTicks(4583), new Guid("e743f790-31b0-4747-b968-7fe2853f8258"), "Salad", 4713.25m, (short)73 });
        }
    }
}
