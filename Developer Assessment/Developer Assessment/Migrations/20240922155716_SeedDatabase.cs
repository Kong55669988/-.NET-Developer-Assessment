using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Developer_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Freelancers",
                columns: new[] { "Id", "CreatedTime", "Hobby", "Mail", "ModifiedTime", "PhoneNumber", "SkillSets", "Username", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6086), "Photography", "john.doe@example.com", new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6088), "123-456-7890", "C#, SQL, ASP.NET", "John Doe", true },
                    { 2, new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6090), "Cycling", "jane.smith@example.com", new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6091), "234-567-8901", "Java, Spring, Hibernate", "Jane Smith", true },
                    { 3, new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6092), "Reading", "michael.brown@example.com", new DateTime(2024, 9, 22, 15, 57, 16, 156, DateTimeKind.Utc).AddTicks(6093), "345-678-9012", "Python, Django, AI", "Michael Brown", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
