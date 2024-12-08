using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace egzas_1.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("00aac29c-00de-4287-a801-65b7d0d0081b"), "user1", new byte[] { 73, 157, 23, 29, 207, 7, 156, 21, 46, 136, 100, 86, 13, 9, 44, 80, 183, 41, 246, 225, 158, 26, 199, 20, 32, 132, 68, 177, 7, 138, 5, 242 }, new byte[] { 8, 80, 217, 152, 156, 222, 29, 38, 34, 112, 231, 54, 167, 149, 224, 70, 72, 84, 164, 238, 199, 90, 194, 240, 10, 112, 45, 67, 239, 224, 146, 195, 6, 102, 83, 213, 198, 198, 46, 128, 167, 22, 245, 169, 123, 163, 45, 77, 209, 76, 38, 133, 217, 113, 235, 47, 241, 212, 167, 9, 110, 5, 45, 188 }, "user" },
                    { new Guid("21816f66-e79e-40e6-aabb-031fd2437088"), "user5", new byte[] { 166, 65, 189, 10, 160, 156, 202, 200, 197, 150, 247, 72, 163, 9, 106, 103, 99, 75, 112, 83, 80, 236, 94, 188, 110, 25, 169, 195, 150, 73, 177, 141 }, new byte[] { 237, 152, 197, 164, 98, 128, 133, 98, 80, 85, 190, 177, 123, 182, 235, 42, 73, 222, 28, 238, 83, 216, 240, 62, 250, 239, 231, 121, 93, 22, 32, 142, 20, 254, 231, 15, 51, 94, 21, 243, 127, 152, 55, 80, 112, 71, 116, 168, 152, 238, 114, 165, 108, 35, 162, 210, 135, 59, 105, 116, 234, 89, 214, 131 }, "user" },
                    { new Guid("3026340b-e5d3-4055-baf7-b6b4fc574c8d"), "user4", new byte[] { 61, 114, 24, 13, 174, 186, 233, 56, 207, 118, 111, 82, 45, 30, 237, 19, 164, 18, 201, 55, 241, 163, 47, 48, 51, 187, 215, 145, 8, 97, 215, 175 }, new byte[] { 99, 207, 26, 20, 22, 23, 229, 252, 70, 162, 184, 134, 116, 237, 66, 156, 179, 130, 211, 167, 63, 199, 243, 24, 91, 147, 232, 237, 141, 38, 1, 148, 197, 241, 192, 22, 8, 90, 31, 252, 117, 204, 43, 243, 243, 162, 37, 18, 230, 242, 75, 47, 228, 107, 205, 11, 17, 161, 197, 27, 168, 61, 199, 131 }, "user" },
                    { new Guid("bdba6124-913d-4a75-82c3-bd2220b5f414"), "user2", new byte[] { 154, 16, 30, 144, 83, 187, 87, 212, 49, 186, 245, 76, 243, 11, 55, 250, 83, 247, 8, 230, 215, 204, 218, 88, 7, 79, 65, 33, 239, 114, 8, 136 }, new byte[] { 125, 148, 19, 222, 192, 198, 207, 151, 155, 108, 71, 108, 241, 185, 81, 124, 33, 221, 187, 64, 140, 183, 1, 6, 154, 159, 4, 184, 81, 55, 235, 94, 243, 70, 154, 226, 239, 65, 204, 217, 30, 49, 30, 198, 242, 175, 102, 213, 188, 234, 25, 10, 246, 19, 36, 27, 165, 53, 8, 70, 214, 65, 147, 229 }, "user" },
                    { new Guid("e14c5c81-088c-4aa1-8ac8-83ace6694e0b"), "user3", new byte[] { 117, 122, 126, 122, 226, 6, 37, 113, 110, 52, 19, 114, 126, 46, 244, 72, 65, 212, 129, 181, 137, 144, 40, 176, 57, 247, 217, 167, 204, 183, 80, 95 }, new byte[] { 9, 206, 101, 77, 74, 206, 15, 38, 123, 53, 186, 31, 229, 241, 49, 49, 178, 85, 123, 250, 240, 47, 203, 180, 7, 154, 56, 50, 131, 81, 24, 100, 116, 41, 237, 80, 230, 94, 246, 223, 70, 16, 221, 115, 108, 121, 34, 202, 249, 119, 173, 10, 72, 21, 69, 155, 104, 207, 44, 176, 101, 186, 98, 181 }, "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "UserCountry", "UserEmail", "UserIdentityNumber", "UserName", "UserResidenceApartmentNumber", "UserResidenceCity", "UserResidenceHouseNumber", "UserResidenceStreet", "UserSurName" },
                values: new object[,]
                {
                    { new Guid("2eabcfcb-ea1a-440d-a8f0-d5ab3da0d3b2"), new Guid("00000000-0000-0000-0000-000000000000"), "USA", "john.doe@example.com", 12345, "John", null, "New York", "123", "Broadway", "Doe" },
                    { new Guid("41d5ded5-2d9e-4527-94f7-ffe46da05d74"), new Guid("00000000-0000-0000-0000-000000000000"), "New Zealand", "emily.davis@example.com", 12321, "Emily", null, "Auckland", "102", "Victoria Street", "Davis" },
                    { new Guid("62e716ef-c6fd-4a72-8bef-b35565eb5fbc"), new Guid("00000000-0000-0000-0000-000000000000"), "Canada", "jane.smith@example.com", 54321, "Jane", null, "Toronto", "456", "Queen Street", "Smith" },
                    { new Guid("df4b7154-4917-4cec-b54d-d9ccdf624643"), new Guid("00000000-0000-0000-0000-000000000000"), "UK", "bob.brown@example.com", 67890, "Bob", null, "London", "221B", "Baker Street", "Brown" },
                    { new Guid("e326ed26-7f89-4a97-9c7d-7834e196a584"), new Guid("00000000-0000-0000-0000-000000000000"), "Australia", "alice.johnson@example.com", 98765, "Alice", null, "Sydney", "789", "George Street", "Johnson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("00aac29c-00de-4287-a801-65b7d0d0081b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("21816f66-e79e-40e6-aabb-031fd2437088"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("3026340b-e5d3-4055-baf7-b6b4fc574c8d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("bdba6124-913d-4a75-82c3-bd2220b5f414"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: new Guid("e14c5c81-088c-4aa1-8ac8-83ace6694e0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2eabcfcb-ea1a-440d-a8f0-d5ab3da0d3b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41d5ded5-2d9e-4527-94f7-ffe46da05d74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62e716ef-c6fd-4a72-8bef-b35565eb5fbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df4b7154-4917-4cec-b54d-d9ccdf624643"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e326ed26-7f89-4a97-9c7d-7834e196a584"));

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
    }
}
