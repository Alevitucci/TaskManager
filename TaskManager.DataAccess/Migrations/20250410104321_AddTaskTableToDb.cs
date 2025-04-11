using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bff27e5-f6d1-462a-8833-26aa4f78c22b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6aa5ff7-7842-4894-9e98-8534dc626a6e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZIPCode" },
                values: new object[,]
                {
                    { "92d20f31-39f6-42f4-88c3-90601cecf574", 0, "C", "0baf8118-3c48-4a7d-a68d-e7b6daf4628c", "ApplicationUser", null, false, false, null, "Nam2", null, null, null, null, false, "f155a69e-545a-4098-bbca-f9981b3fbf64", "S", "V", false, null, "BOH" },
                    { "ddb87deb-2633-4ae1-b360-b039fa2609c7", 0, "Roma", "531ec5d5-fbf4-443c-b4e1-904536d1b2c1", "ApplicationUser", null, false, false, null, "AC", null, null, null, null, false, "32a5d61b-76bb-434c-8d4b-199203eb0fa6", "Italy", "Via delle Albizie 22", false, null, "BOH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d20f31-39f6-42f4-88c3-90601cecf574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddb87deb-2633-4ae1-b360-b039fa2609c7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZIPCode" },
                values: new object[,]
                {
                    { "9bff27e5-f6d1-462a-8833-26aa4f78c22b", 0, "C", "a4c573e7-9829-4e71-84b0-7838a7e7a67b", "ApplicationUser", null, false, false, null, "Nam2", null, null, null, null, false, "6a90cee3-dc4d-47fd-a848-1c1efbd5e9a0", "S", "V", false, null, "BOH" },
                    { "e6aa5ff7-7842-4894-9e98-8534dc626a6e", 0, "Roma", "abe510cb-2abd-4f26-98f7-eabe10f0dd2b", "ApplicationUser", null, false, false, null, "AC", null, null, null, null, false, "d7f7899d-293f-4a2b-a4b5-f115666862fa", "Italy", "Via delle Albizie 22", false, null, "BOH" }
                });
        }
    }
}
