using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class orderitemss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8529), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8532), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8533), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8545), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8558), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8562), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8563), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8567), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8568), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8577), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8578), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8614), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8617), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8618), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8619), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8626), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8628), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8632), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8638), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8645), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8651), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8652), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8653), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8654), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8655), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8658), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8661), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8662), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8663), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8665), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8666), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8668), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8669), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8671), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8675), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8682), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8691), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8694), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8813), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8814), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8817), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8835), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8838), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8885), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8903), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8946), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8979), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8985), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9002), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9009), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9011), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9014), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9021), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9024), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9037), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9047), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9053), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9054), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9091), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9093), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9095), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9097), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9101), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9107), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9111), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9120), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9123), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9124), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9129), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9131), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9133), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9135), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9139), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9141), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9143), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9144), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9146), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9149), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9150), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9151), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9152), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9156), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9159), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9162), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9175), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9179), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9188), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9192), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9194), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9197), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9200), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9202), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9203), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9205), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9208), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9212), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9213), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9214), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9248), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9249), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9251), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9252), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9253), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9254), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9259), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9266), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9272), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9277), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9278), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9281), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9283), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9285), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9286), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9287), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9289), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9290), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9291), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9293), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9294), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9296), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9297), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9299), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9304), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9307), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9310), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9312), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9315), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9316), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9318), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9320), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9321), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9322), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9325), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9328), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9331), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9332), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9335), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9339), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9340), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9346), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9348), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9351), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9353), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9360), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9361), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9362), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9363), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9365), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9367), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9368), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9375), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9377), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9379), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9414), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9416), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9421), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9422), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9423), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9426), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9427), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9428), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9432), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9433), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9435), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9436), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9437), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9438), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9439), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9440), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9442), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9443), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9445), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9446), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9447), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9448), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9451), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9453), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9460), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9462), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9466), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9467), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9470), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9471), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9473), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9476), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9477), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9478), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9480), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9481), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9482), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9485), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9487), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9490), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9502), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9503), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9504), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9505), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9508), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9509), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9511), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9513), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9514), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9516), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9517), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9518), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9519), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9520), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9522), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9523), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9527), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9529), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9532), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9533), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9534), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9568), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9573), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9575), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9576), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9578), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9580), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9581), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9584), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9585), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9587), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9588), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9589), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9590), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9591), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9592), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9594), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9596), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9598), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9600), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9601), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9603), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9604), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9605), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9606), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9607), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9608), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9612), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9613), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9614), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9615), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9616), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9617), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9623), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9625), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9627), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9631), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9632), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9634), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9635), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9636), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9638), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9639), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9642), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9643), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9646), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9652), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9653), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9657), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9662), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9666), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9669), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9674), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9677), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9682), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9687), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9720), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9724), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9729), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9736), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9745), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9747), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9752), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9753), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9757), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9760), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9771), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9789), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9795), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9816), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9821), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9822), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9824), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9829), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9831), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9835), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9874), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9877), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9887), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9893), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9909), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9916), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9925), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9932), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9938), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9939), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9940), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9948), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9951), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9963), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9966), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9980), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9997), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 522, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(57), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(58), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(60), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(61), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(64), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(65), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(76), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(80), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(82), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(84), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(86), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(89), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(92), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(93), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(95), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(96), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(101), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(102), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(104), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(105), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(107), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(108), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(110), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(112), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(114), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(116), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(119), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(122), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(124), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(126), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(127), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(131), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(134), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(139), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(143), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(149), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(150), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(154), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(160), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(162), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(164), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(166), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(167), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(169), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(171), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(172), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(175), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(212), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(217), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(218), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(222), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(224), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(225), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(236), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(237), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(242), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 4, 28, 18, 52, 51, 523, DateTimeKind.Local).AddTicks(244) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2688), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2724), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2751), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2764), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2839), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2861), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2866), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2880), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2888), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2893), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2898), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2925), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2934), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3003), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3006), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3029), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3032), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3046), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3049), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3076), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3090), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3142), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3149), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3153), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3155), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3162), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3164), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3167), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3168), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3169), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3171), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3173), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3179), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3180), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3181), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3183), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3205), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3206), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3207), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3217), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3223), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3248), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3251), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3254), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3255), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3257), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3265), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3267), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3327), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3330), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3342), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3348), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3350), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3352), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3356), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3358), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3360), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3361), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3362), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3365), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3366), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3367), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3370), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3371), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3373), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3375), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3376), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3379), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3380), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3381), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3383), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3387), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3388), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3389), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3391), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3392), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3395), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3397), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3399), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3400), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3402), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3406), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3407), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3408), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3410), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3411), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3421), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3423), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3426), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3434), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3439), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3444), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3528), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3530), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3531), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3534), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3535), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3537), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3539), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3541), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3543), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3544), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3545), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3546), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3548), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3553), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3555), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3559), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3560), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3562), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3564), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3566), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3567), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3570), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3571), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3572), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3575), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3576), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3577), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3580), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3584), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3586), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3591), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3592), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3595), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3609), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3630), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3631), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3635), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3639), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3645), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3647), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3649), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3651), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3652), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3689), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3691), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3693), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3694), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3696), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3702), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3703), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3706), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3710), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3711), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3716), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3718), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3719), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3720), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3724), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3726), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3728), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3729), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3731), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3732), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3733), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3736), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3737), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3741), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3742), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3749), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3755), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3758), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3759), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3760), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3763), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3764), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3770), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3774), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3777), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3780), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3781), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3783), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3784), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3786), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3790), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3792), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3793), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3796), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3798), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3800), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3801), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3802), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3803), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3804), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3806), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3808), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3809), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3810), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3811), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3812), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3814), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3815), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3850), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3852), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3853), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3856), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3860), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3862), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3867), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3869), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3871), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3874), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3879), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3880), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3882), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3883), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3887), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3889), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3891), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3894), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3896), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3897), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3898), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3899), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3900), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3904), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3905), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3906), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3908), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3910), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3911), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3912), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3913), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3915), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3917), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3918), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3920), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3921), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3924), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3925), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3928), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3930), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3931), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3933), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3935), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3937), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3939), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3942), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3944), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3953), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3956), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3958), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3959), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3962), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3965), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3966), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3968), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3971), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4008), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4009), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4012), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4013), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4014), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4016), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4017), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4018), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4022), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4025), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4035), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4038), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4039), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4042), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4044), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4045), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4046), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4048), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4050), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4052), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4056), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4057), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4062), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4063), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4065), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4066), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4067), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4069), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4070), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4071), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4072), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4074), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4075), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4076), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4078), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4079), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4081), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4082), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4083), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4084), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4085), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4087), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4088), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4089), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4100), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4109), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4111), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4113), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4114), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4115), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4117), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4119), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4120), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4123), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4124), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4125), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4126), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4128), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4129), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4130), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4181), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4216), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4227), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4235), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4236), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4240), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4242), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4243), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4247), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4252), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4257), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4260), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4262), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4268), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4278), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4293), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4302), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4339), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4340), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4342), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4343), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4347), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4355), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4359), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4360), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4362), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4363), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4366), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4367), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4369), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4370), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4373), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4374), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4377), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4378), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4380), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4381), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4383), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4385), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4387), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4392), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4393), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4394), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4397), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4399), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4405), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4412), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4415), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4417), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4419), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4421), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4424), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4426), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4429), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4445), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4446), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4449), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4454), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4456), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4459), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4500), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4503), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4504), new DateTime(2023, 4, 27, 19, 47, 31, 949, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
