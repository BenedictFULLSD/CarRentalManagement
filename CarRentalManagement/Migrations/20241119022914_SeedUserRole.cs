using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administartor", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f01fc74b-a01c-46ab-8bb2-f28862968fb6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEAtUk3PbzAGcz7bLgkO0YlTCinbslaXrLscN1/c9RbrHEjOB68x7pbXe2YVtMXrnQ==", null, false, "2950c435-855d-4111-ae72-46d1c93ff896", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(1591), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2375), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2383), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2386), new DateTime(2024, 11, 19, 10, 29, 11, 586, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(2715), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(2748), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4970), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4978), new DateTime(2024, 11, 18, 17, 48, 34, 279, DateTimeKind.Local).AddTicks(4979) });
        }
    }
}
