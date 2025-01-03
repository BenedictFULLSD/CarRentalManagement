﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3064), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3078), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3081), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3081), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3329), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3332), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3428), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3431), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3433), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 11, 18, 17, 2, 22, 855, DateTimeKind.Local).AddTicks(3435), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
