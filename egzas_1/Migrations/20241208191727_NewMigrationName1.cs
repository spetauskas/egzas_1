using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace egzas_1.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationName1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName", "AccountPasswordHash", "AccountPasswordSalt", "AccountRole" },
                values: new object[,]
                {
                    { new Guid("1ca03590-fb8e-4926-b202-5477c0476362"), "user3", new byte[] { 153, 245, 109, 31, 133, 54, 136, 64, 108, 246, 54, 244, 64, 247, 122, 10, 64, 9, 120, 144, 239, 36, 224, 13, 171, 76, 36, 251, 92, 79, 192, 208 }, new byte[] { 182, 47, 141, 136, 164, 183, 191, 59, 129, 49, 183, 103, 113, 99, 211, 217, 204, 217, 45, 118, 90, 109, 115, 123, 155, 175, 110, 201, 163, 232, 246, 205, 221, 149, 174, 153, 70, 199, 56, 218, 37, 185, 21, 127, 94, 38, 107, 113, 163, 81, 222, 143, 156, 11, 220, 70, 128, 20, 6, 224, 188, 199, 213, 37 }, "user" },
                    { new Guid("4a51d102-78f5-4570-bffd-624e1323c42f"), "user2", new byte[] { 9, 209, 141, 129, 41, 79, 191, 117, 89, 156, 66, 234, 187, 210, 65, 92, 117, 73, 194, 82, 8, 193, 139, 236, 68, 222, 90, 69, 239, 171, 76, 77 }, new byte[] { 102, 138, 13, 146, 73, 88, 150, 20, 254, 186, 17, 241, 54, 62, 46, 89, 128, 20, 244, 86, 255, 171, 162, 33, 114, 21, 25, 15, 163, 253, 218, 25, 159, 29, 16, 215, 225, 249, 14, 230, 120, 65, 93, 75, 15, 165, 166, 204, 60, 110, 212, 55, 91, 166, 3, 255, 43, 103, 43, 98, 66, 111, 222, 138 }, "user" },
                    { new Guid("5c9b720b-544e-4056-85e5-461cf03761d6"), "user4", new byte[] { 17, 68, 97, 109, 240, 103, 120, 40, 162, 103, 172, 81, 16, 155, 200, 27, 17, 251, 218, 47, 237, 6, 183, 244, 27, 68, 79, 78, 54, 62, 8, 112 }, new byte[] { 146, 211, 18, 117, 74, 30, 233, 250, 210, 22, 28, 198, 17, 3, 39, 179, 131, 89, 153, 230, 1, 136, 64, 104, 52, 88, 88, 241, 247, 207, 23, 60, 167, 245, 240, 144, 9, 253, 213, 237, 242, 53, 98, 77, 77, 191, 85, 229, 13, 204, 113, 23, 36, 89, 210, 180, 163, 231, 106, 35, 49, 146, 126, 43 }, "user" },
                    { new Guid("85c9329c-fabe-4aaa-b882-cbaee9bddc5d"), "user5", new byte[] { 175, 124, 34, 183, 156, 95, 206, 149, 26, 91, 62, 94, 138, 251, 57, 126, 252, 190, 49, 51, 51, 4, 64, 181, 86, 174, 184, 117, 93, 42, 68, 121 }, new byte[] { 204, 234, 226, 87, 101, 23, 24, 71, 3, 14, 212, 229, 79, 135, 112, 109, 29, 186, 188, 164, 92, 145, 149, 52, 76, 158, 198, 181, 119, 131, 156, 102, 170, 56, 35, 181, 137, 198, 116, 191, 11, 148, 207, 170, 227, 65, 188, 18, 244, 146, 151, 170, 177, 126, 5, 232, 27, 115, 229, 143, 60, 192, 7, 188 }, "user" },
                    { new Guid("9ec13743-1fce-4057-8f1b-78df03d21c79"), "user1", new byte[] { 116, 225, 191, 93, 205, 153, 57, 233, 30, 55, 36, 78, 104, 22, 161, 222, 41, 27, 63, 177, 182, 151, 17, 8, 239, 218, 203, 172, 244, 12, 84, 133 }, new byte[] { 39, 129, 55, 153, 42, 237, 202, 9, 116, 138, 128, 41, 124, 156, 101, 236, 61, 170, 190, 95, 230, 83, 33, 164, 41, 212, 25, 163, 38, 238, 16, 104, 58, 126, 96, 46, 49, 189, 221, 228, 222, 208, 59, 33, 53, 83, 107, 213, 244, 10, 13, 243, 136, 26, 46, 194, 61, 108, 79, 180, 117, 171, 116, 163 }, "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "UserCountry", "UserEmail", "UserIdentityNumber", "UserName", "UserResidenceApartmentNumber", "UserResidenceCity", "UserResidenceHouseNumber", "UserResidenceStreet", "UserSurName" },
                values: new object[,]
                {
                    { new Guid("61330907-5574-47fa-bbd0-9f7c03c2104c"), new Guid("00000000-0000-0000-0000-000000000000"), "UK", "bob.brown@example.com", 67890, "Bob", null, "London", "221B", "Baker Street", "Brown" },
                    { new Guid("7001915e-ee75-4403-b4d3-9bff679a9f05"), new Guid("00000000-0000-0000-0000-000000000000"), "New Zealand", "emily.davis@example.com", 12321, "Emily", null, "Auckland", "102", "Victoria Street", "Davis" },
                    { new Guid("875ee5a6-bfb9-4662-a74f-3ed10c2e940c"), new Guid("00000000-0000-0000-0000-000000000000"), "USA", "john.doe@example.com", 12345, "John", null, "New York", "123", "Broadway", "Doe" },
                    { new Guid("95c5de67-ef48-46b4-a94d-8a9ad45db882"), new Guid("00000000-0000-0000-0000-000000000000"), "Canada", "jane.smith@example.com", 54321, "Jane", null, "Toronto", "456", "Queen Street", "Smith" },
                    { new Guid("b5fcd216-0b0e-46ae-b780-144d62dd1478"), new Guid("00000000-0000-0000-0000-000000000000"), "Australia", "alice.johnson@example.com", 98765, "Alice", null, "Sydney", "789", "George Street", "Johnson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("1ca03590-fb8e-4926-b202-5477c0476362"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("4a51d102-78f5-4570-bffd-624e1323c42f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("5c9b720b-544e-4056-85e5-461cf03761d6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("85c9329c-fabe-4aaa-b882-cbaee9bddc5d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("9ec13743-1fce-4057-8f1b-78df03d21c79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61330907-5574-47fa-bbd0-9f7c03c2104c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7001915e-ee75-4403-b4d3-9bff679a9f05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("875ee5a6-bfb9-4662-a74f-3ed10c2e940c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95c5de67-ef48-46b4-a94d-8a9ad45db882"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5fcd216-0b0e-46ae-b780-144d62dd1478"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName", "AccountPasswordHash", "AccountPasswordSalt", "AccountRole" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "DefaultAdmin", new byte[0], new byte[0], "admin" });
        }
    }
}
