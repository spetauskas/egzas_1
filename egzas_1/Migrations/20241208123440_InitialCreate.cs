using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace egzas_1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountPasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AccountPasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AccountRole = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserIdentityNumber = table.Column<int>(type: "int", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserResidenceCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserResidenceStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserResidenceHouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserResidenceApartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName", "AccountPasswordHash", "AccountPasswordSalt", "AccountRole" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "DefaultAdmin", new byte[0], new byte[0], "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                table: "Users",
                column: "AccountId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
