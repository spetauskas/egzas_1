using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace egzas_1.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
