using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class güncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 456, DateTimeKind.Local).AddTicks(1549), new Guid("a7cd84a4-d95f-41a9-a818-931faf6cf058") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 456, DateTimeKind.Local).AddTicks(1691), new Guid("db80246d-4b65-4fe7-a585-bf194b42adeb") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 456, DateTimeKind.Local).AddTicks(1697), new Guid("7c60ac5d-cf24-41a4-8afc-98582f4fa765") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(5916), new Guid("044069a4-43a2-406c-a985-609138e3975a"), "Chair", 2233.01m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6266), new Guid("ba819e3d-615b-415b-9f03-1f31e0b449d6"), "Pants", 5376.64m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6289), new Guid("0d5a0cd5-5b44-426b-80de-311b68a1f653"), "Fish", 4923.52m, (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6304), new Guid("3d5bc271-1744-4af3-8783-acc6d2d3768b"), "Pizza", 4833.41m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6317), new Guid("37e8fe36-a6bf-404a-b396-e4fd160a8694"), "Pants", 9777.04m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6330), new Guid("b3e865d1-78b7-49ac-badc-1706142e4f96"), "Table", 221.89m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6751), new Guid("0549887c-3b1d-4b1f-a84e-092ad82a95ab"), "Table", 3076.83m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6841), new Guid("b3853a4b-8bfb-4cae-9d79-ee5dd155fd98"), "Keyboard", 8302.23m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6856), new Guid("6b0deb0f-c6eb-4d56-969a-f1fd02bf559d"), "Soap", 7711.43m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6875), new Guid("d131d8d5-162d-4d04-a5ce-465536696c8e"), 3590.77m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6889), new Guid("fc03685e-7693-47ba-81d5-c4e110fa339d"), "Gloves", 8731.42m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6901), new Guid("40b66d64-762b-4c2a-bf7a-35112360c033"), "Car", 6794.40m, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6914), new Guid("f23da922-3683-4ed1-a841-98cf9b1b635b"), "Shoes", 7128.84m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6927), new Guid("ed9ce995-4799-43f6-8d79-732b5563ce7d"), "Shoes", 553.24m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6942), new Guid("10dbbea9-3c98-4b9c-8986-f3f11dace4d4"), "Salad", 7227.32m, (short)76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6954), new Guid("c0dd22b1-9053-4c2f-aa31-e34cbe2d855b"), "Shirt", 1982.73m, (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6966), new Guid("76851641-11d4-43cb-a32c-31e307356f7e"), "Towels", 6093.27m, (short)46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6982), new Guid("fe041872-08ff-45ad-bbd6-8cd632fadece"), "Sausages", 4487.73m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(6994), new Guid("3ef824c7-f4ed-4949-bbce-190aad27ad74"), "Shirt", 5913.04m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(7006), new Guid("846cf43d-fb43-435e-8440-9fed51d76fca"), "Shirt", 2585.04m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(9058), new Guid("584ef8b2-70e8-402d-be37-ee84dbd66e22") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(9083), new Guid("5f639e92-9ff9-4005-8ce2-015c8557efc7") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 6, 29, 463, DateTimeKind.Local).AddTicks(9345), new Guid("5ab69c07-d0cd-4922-b9bf-3af807d09b0c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 832, DateTimeKind.Local).AddTicks(8275), new Guid("66143988-71bf-4d75-b1ec-e38da02ab6af") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 832, DateTimeKind.Local).AddTicks(8370), new Guid("022f3bc0-c4c0-4755-8552-a507e72dd0c3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 832, DateTimeKind.Local).AddTicks(8375), new Guid("bba040e2-06f9-4404-bb6b-758aed194ea0") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6368), new Guid("80db8dad-5155-446b-97fa-7acf9f45bf96"), "Towels", 2338.48m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6679), new Guid("af75804e-478c-4c41-86f9-cdfe32dd5ffb"), "Gloves", 7490.83m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6698), new Guid("ca67ff89-f93c-46a7-a2d6-0d0d1964cb2a"), "Bike", 981.21m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6710), new Guid("ff4bf913-99e6-4926-9da2-40f3118083d5"), "Towels", 2064.94m, (short)100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6733), new Guid("85aac792-d95c-45bb-9365-0d4c39844e89"), "Bacon", 3466.76m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6746), new Guid("b7367c95-dcd7-4168-b26d-7e91c2a2a5ff"), "Chips", 2977.68m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6757), new Guid("a0985182-03a9-4591-84a4-cc66cb28063c"), "Tuna", 8116.65m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6768), new Guid("a949afcc-7ded-403b-b0ee-8faba48de333"), "Cheese", 4221.14m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6777), new Guid("380afd28-0019-4430-9e61-d3f815c19486"), "Bacon", 6264.78m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6787), new Guid("4acf40e0-f0b7-4217-81b0-504f01d6385e"), 771.29m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6798), new Guid("dafe521b-97f5-4cfa-9f4a-a5f3185c0673"), "Table", 4734.55m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6864), new Guid("e93586e6-2e00-4cc6-a14b-5b8ff11361a8"), "Shirt", 2173.97m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6879), new Guid("6567a8bc-62a8-4edd-bb69-490e347167b3"), "Chips", 5374.39m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6889), new Guid("07f7e4b5-d5a2-4bd9-8767-516a197c4bb8"), "Chips", 4021.23m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6899), new Guid("a72c9e78-5e93-4047-8bbe-b856c17fe2c8"), "Pizza", 5286.87m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6910), new Guid("340bc6fd-e34b-4c2e-b16c-90f85dc3d846"), "Shoes", 5358.42m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6920), new Guid("7e505c07-6677-4663-9a34-efa873f5757e"), "Chair", 1186.83m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6932), new Guid("021b374b-4a8e-4b1b-9c63-8523cec7e102"), "Shirt", 4800.09m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6943), new Guid("8a408e5b-23a8-476c-b3d7-0aa340674313"), "Soap", 5216.03m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(6954), new Guid("a54b0b3c-964d-4edc-994b-41880e48e98d"), "Pizza", 6372.47m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(8621), new Guid("c8456bde-4369-449d-85b8-43e4ac44ab71") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(8637), new Guid("f3b42ff8-d628-4276-8b67-efb33f287542") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 20, 38, 835, DateTimeKind.Local).AddTicks(8641), new Guid("73730707-72c0-45b9-95e3-5573f9839200") });
        }
    }
}
