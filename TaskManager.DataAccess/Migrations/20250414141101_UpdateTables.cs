using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d20f31-39f6-42f4-88c3-90601cecf574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddb87deb-2633-4ae1-b360-b039fa2609c7");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Starting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ending = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZIPCode" },
                values: new object[,]
                {
                    { "48eb8f80-e275-43e0-a8f3-eab681f9145c", 0, "C", "cb5c2d78-f8ac-4e53-8c45-e0fdbe2bc629", "ApplicationUser", null, false, false, null, "Nam2", null, null, null, null, false, "e2e9f3ea-1337-4f52-a8a5-7b701e444217", "S", "V", false, null, "BOH" },
                    { "5a8df75a-64d0-4ca5-be59-da4d10558cee", 0, "Roma", "31f5cb9f-8960-461b-9bc3-c3e7204de1e7", "ApplicationUser", null, false, false, null, "AC", null, null, null, null, false, "95871ead-005d-4b97-acdf-c3a7e5bd0213", "Italy", "Via delle Albizie 22", false, null, "BOH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

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
                    { "92d20f31-39f6-42f4-88c3-90601cecf574", 0, "C", "0baf8118-3c48-4a7d-a68d-e7b6daf4628c", "ApplicationUser", null, false, false, null, "Nam2", null, null, null, null, false, "f155a69e-545a-4098-bbca-f9981b3fbf64", "S", "V", false, null, "BOH" },
                    { "ddb87deb-2633-4ae1-b360-b039fa2609c7", 0, "Roma", "531ec5d5-fbf4-443c-b4e1-904536d1b2c1", "ApplicationUser", null, false, false, null, "AC", null, null, null, null, false, "32a5d61b-76bb-434c-8d4b-199203eb0fa6", "Italy", "Via delle Albizie 22", false, null, "BOH" }
                });
        }
    }
}
