using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAssignmentsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48eb8f80-e275-43e0-a8f3-eab681f9145c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a8df75a-64d0-4ca5-be59-da4d10558cee");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZIPCode" },
                values: new object[,]
                {
                    { "28fc0c8e-f661-4638-9ff0-b0f422d9a08b", 0, "Roma", "164c60aa-22c0-4870-91d5-05e0447e3290", "ApplicationUser", null, false, false, null, "AC", null, null, null, null, false, "53d7d889-1362-4226-88c2-d1e6d4479d7c", "Italy", "Via delle Albizie 22", false, null, "BOH" },
                    { "896a3623-2da1-4abf-923a-30afd6205c1f", 0, "C", "2ec06ff8-250c-4be6-a2a5-28940ae5f122", "ApplicationUser", null, false, false, null, "Nam2", null, null, null, null, false, "eb41f076-1339-41f4-8f2d-c1e8759e5df2", "S", "V", false, null, "BOH" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Description", "Ending", "Starting", "Status", "TaskName" },
                values: new object[,]
                {
                    { 1, "Descrizione 1", new DateTime(2025, 5, 1, 11, 12, 17, 925, DateTimeKind.Local).AddTicks(9268), new DateTime(2025, 4, 23, 11, 12, 17, 925, DateTimeKind.Local).AddTicks(9232), "Completed", "Ricreare il sacro romano impero" },
                    { 2, "Descrizione 2", new DateTime(2025, 5, 11, 11, 12, 17, 925, DateTimeKind.Local).AddTicks(9272), new DateTime(2025, 4, 30, 11, 12, 17, 925, DateTimeKind.Local).AddTicks(9271), "Approved", "Completare il Pokedex" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28fc0c8e-f661-4638-9ff0-b0f422d9a08b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896a3623-2da1-4abf-923a-30afd6205c1f");

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZIPCode" },
                values: new object[,]
                {
                    { "48eb8f80-e275-43e0-a8f3-eab681f9145c", 0, "C", "cb5c2d78-f8ac-4e53-8c45-e0fdbe2bc629", "ApplicationUser", null, false, false, null, "Nam2", null, null, null, null, false, "e2e9f3ea-1337-4f52-a8a5-7b701e444217", "S", "V", false, null, "BOH" },
                    { "5a8df75a-64d0-4ca5-be59-da4d10558cee", 0, "Roma", "31f5cb9f-8960-461b-9bc3-c3e7204de1e7", "ApplicationUser", null, false, false, null, "AC", null, null, null, null, false, "95871ead-005d-4b97-acdf-c3a7e5bd0213", "Italy", "Via delle Albizie 22", false, null, "BOH" }
                });
        }
    }
}
