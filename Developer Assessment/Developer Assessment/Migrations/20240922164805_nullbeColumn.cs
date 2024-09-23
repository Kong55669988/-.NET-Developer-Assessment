using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Developer_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class nullbeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 48, 4, 984, DateTimeKind.Utc).AddTicks(1872), new DateTime(2024, 9, 22, 16, 48, 4, 984, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 48, 4, 984, DateTimeKind.Utc).AddTicks(1876), new DateTime(2024, 9, 22, 16, 48, 4, 984, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 48, 4, 984, DateTimeKind.Utc).AddTicks(1878), new DateTime(2024, 9, 22, 16, 48, 4, 984, DateTimeKind.Utc).AddTicks(1878) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6086), new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6092), new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6093) });
        }
    }
}
