using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace egzas_1.Migrations
{
    /// <inheritdoc />
    public partial class Create2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName", "AccountPasswordHash", "AccountPasswordSalt", "AccountRole" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "DefaultAdmin", new byte[0], new byte[0], "admin" });
        }
    }
}
