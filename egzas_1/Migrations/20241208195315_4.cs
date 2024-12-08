using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace egzas_1.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("8479310a-b8fd-4cfb-bb78-c69354f96165"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("9243f6f3-d5bd-4749-965c-adba719368ad"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("c411020f-a24f-42a0-98a5-5424db5c668d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("e0a1d99d-98b3-4542-9ec0-57516ab0d09d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("f8d98021-5b7e-441a-b39f-cf5d09b2192c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61cc02e4-d5d5-4194-9c44-29fb876b3b72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("642420fa-6378-42ff-a97e-144416eb1d64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c32e179-61ad-40b1-919f-b73252008a85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3956c64-8a27-4708-84a1-2c9eb4141d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4e371f4-e66f-4944-bdb2-ca6217d316db"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName", "AccountPasswordHash", "AccountPasswordSalt", "AccountRole" },
                values: new object[,]
                {
                    { new Guid("8479310a-b8fd-4cfb-bb78-c69354f96165"), "user1", new byte[] { 75, 108, 243, 223, 41, 243, 55, 201, 187, 72, 81, 221, 8, 72, 202, 255, 239, 137, 73, 208, 103, 203, 1, 158, 48, 41, 126, 74, 18, 13, 223, 42 }, new byte[] { 47, 80, 32, 138, 253, 247, 110, 67, 229, 87, 175, 227, 113, 204, 85, 69, 177, 3, 74, 118, 195, 66, 91, 99, 241, 152, 19, 245, 214, 216, 134, 22, 112, 186, 197, 29, 187, 150, 249, 5, 255, 23, 74, 31, 199, 3, 40, 94, 59, 145, 125, 227, 12, 59, 213, 66, 120, 233, 182, 170, 230, 37, 159, 229 }, "user" },
                    { new Guid("9243f6f3-d5bd-4749-965c-adba719368ad"), "user2", new byte[] { 198, 240, 166, 247, 9, 66, 221, 191, 50, 203, 126, 213, 189, 15, 15, 52, 154, 89, 183, 249, 32, 68, 213, 4, 185, 239, 237, 222, 10, 95, 140, 9 }, new byte[] { 195, 76, 52, 162, 146, 74, 158, 120, 72, 169, 108, 98, 168, 28, 96, 27, 105, 177, 77, 225, 255, 21, 213, 152, 158, 62, 104, 167, 108, 64, 99, 147, 85, 23, 102, 225, 70, 112, 116, 169, 116, 196, 61, 180, 20, 61, 215, 72, 18, 77, 95, 96, 66, 245, 245, 50, 10, 62, 197, 118, 128, 157, 17, 23 }, "user" },
                    { new Guid("c411020f-a24f-42a0-98a5-5424db5c668d"), "user5", new byte[] { 74, 30, 56, 59, 224, 16, 11, 65, 196, 165, 35, 138, 221, 57, 95, 13, 27, 107, 85, 248, 222, 65, 85, 47, 42, 41, 117, 152, 21, 85, 104, 61 }, new byte[] { 124, 100, 35, 0, 187, 61, 7, 29, 137, 146, 5, 57, 168, 17, 132, 253, 58, 254, 81, 200, 62, 61, 164, 73, 158, 68, 35, 217, 246, 235, 173, 35, 75, 190, 145, 86, 231, 218, 250, 36, 226, 221, 246, 81, 143, 83, 66, 143, 219, 188, 91, 86, 73, 27, 174, 0, 243, 129, 248, 227, 104, 72, 68, 200 }, "user" },
                    { new Guid("e0a1d99d-98b3-4542-9ec0-57516ab0d09d"), "user3", new byte[] { 20, 117, 16, 207, 44, 98, 116, 252, 251, 67, 253, 118, 26, 139, 15, 53, 102, 38, 196, 134, 15, 53, 187, 44, 238, 134, 78, 228, 241, 229, 148, 167 }, new byte[] { 216, 51, 208, 26, 159, 88, 84, 249, 194, 93, 199, 17, 232, 13, 59, 101, 15, 8, 178, 65, 94, 171, 79, 234, 119, 152, 186, 23, 8, 231, 212, 34, 34, 19, 125, 141, 181, 245, 231, 181, 206, 172, 200, 249, 96, 223, 205, 51, 82, 113, 207, 236, 211, 189, 155, 11, 71, 165, 116, 112, 134, 132, 152, 131 }, "user" },
                    { new Guid("f8d98021-5b7e-441a-b39f-cf5d09b2192c"), "user4", new byte[] { 34, 48, 60, 103, 109, 191, 75, 68, 3, 115, 74, 244, 118, 0, 25, 92, 97, 40, 138, 17, 215, 236, 96, 227, 142, 235, 30, 55, 122, 178, 87, 165 }, new byte[] { 5, 31, 109, 184, 35, 195, 110, 161, 166, 244, 17, 74, 191, 175, 169, 232, 14, 130, 211, 116, 14, 207, 155, 157, 171, 164, 143, 104, 17, 44, 92, 132, 43, 150, 2, 48, 42, 234, 219, 75, 100, 231, 94, 195, 38, 255, 150, 183, 97, 96, 97, 237, 168, 173, 141, 203, 15, 203, 106, 251, 71, 154, 172, 20 }, "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "UserCountry", "UserEmail", "UserIdentityNumber", "UserName", "UserResidenceApartmentNumber", "UserResidenceCity", "UserResidenceHouseNumber", "UserResidenceStreet", "UserSurName" },
                values: new object[,]
                {
                    { new Guid("61cc02e4-d5d5-4194-9c44-29fb876b3b72"), new Guid("00000000-0000-0000-0000-000000000000"), "Australia", "alice.johnson@example.com", 98765, "Alice", null, "Sydney", "789", "George Street", "Johnson" },
                    { new Guid("642420fa-6378-42ff-a97e-144416eb1d64"), new Guid("00000000-0000-0000-0000-000000000000"), "UK", "bob.brown@example.com", 67890, "Bob", null, "London", "221B", "Baker Street", "Brown" },
                    { new Guid("7c32e179-61ad-40b1-919f-b73252008a85"), new Guid("00000000-0000-0000-0000-000000000000"), "USA", "john.doe@example.com", 12345, "John", null, "New York", "123", "Broadway", "Doe" },
                    { new Guid("e3956c64-8a27-4708-84a1-2c9eb4141d31"), new Guid("00000000-0000-0000-0000-000000000000"), "New Zealand", "emily.davis@example.com", 12321, "Emily", null, "Auckland", "102", "Victoria Street", "Davis" },
                    { new Guid("f4e371f4-e66f-4944-bdb2-ca6217d316db"), new Guid("00000000-0000-0000-0000-000000000000"), "Canada", "jane.smith@example.com", 54321, "Jane", null, "Toronto", "456", "Queen Street", "Smith" }
                });
        }
    }
}
