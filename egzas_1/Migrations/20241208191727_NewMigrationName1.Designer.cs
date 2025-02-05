﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using egzas_1;

#nullable disable

namespace egzas_1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241208191727_NewMigrationName1")]
    partial class NewMigrationName1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("AccountPasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("AccountPasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("AccountRole")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = new Guid("9ec13743-1fce-4057-8f1b-78df03d21c79"),
                            AccountName = "user1",
                            AccountPasswordHash = new byte[] { 116, 225, 191, 93, 205, 153, 57, 233, 30, 55, 36, 78, 104, 22, 161, 222, 41, 27, 63, 177, 182, 151, 17, 8, 239, 218, 203, 172, 244, 12, 84, 133 },
                            AccountPasswordSalt = new byte[] { 39, 129, 55, 153, 42, 237, 202, 9, 116, 138, 128, 41, 124, 156, 101, 236, 61, 170, 190, 95, 230, 83, 33, 164, 41, 212, 25, 163, 38, 238, 16, 104, 58, 126, 96, 46, 49, 189, 221, 228, 222, 208, 59, 33, 53, 83, 107, 213, 244, 10, 13, 243, 136, 26, 46, 194, 61, 108, 79, 180, 117, 171, 116, 163 },
                            AccountRole = "user"
                        },
                        new
                        {
                            AccountId = new Guid("4a51d102-78f5-4570-bffd-624e1323c42f"),
                            AccountName = "user2",
                            AccountPasswordHash = new byte[] { 9, 209, 141, 129, 41, 79, 191, 117, 89, 156, 66, 234, 187, 210, 65, 92, 117, 73, 194, 82, 8, 193, 139, 236, 68, 222, 90, 69, 239, 171, 76, 77 },
                            AccountPasswordSalt = new byte[] { 102, 138, 13, 146, 73, 88, 150, 20, 254, 186, 17, 241, 54, 62, 46, 89, 128, 20, 244, 86, 255, 171, 162, 33, 114, 21, 25, 15, 163, 253, 218, 25, 159, 29, 16, 215, 225, 249, 14, 230, 120, 65, 93, 75, 15, 165, 166, 204, 60, 110, 212, 55, 91, 166, 3, 255, 43, 103, 43, 98, 66, 111, 222, 138 },
                            AccountRole = "user"
                        },
                        new
                        {
                            AccountId = new Guid("1ca03590-fb8e-4926-b202-5477c0476362"),
                            AccountName = "user3",
                            AccountPasswordHash = new byte[] { 153, 245, 109, 31, 133, 54, 136, 64, 108, 246, 54, 244, 64, 247, 122, 10, 64, 9, 120, 144, 239, 36, 224, 13, 171, 76, 36, 251, 92, 79, 192, 208 },
                            AccountPasswordSalt = new byte[] { 182, 47, 141, 136, 164, 183, 191, 59, 129, 49, 183, 103, 113, 99, 211, 217, 204, 217, 45, 118, 90, 109, 115, 123, 155, 175, 110, 201, 163, 232, 246, 205, 221, 149, 174, 153, 70, 199, 56, 218, 37, 185, 21, 127, 94, 38, 107, 113, 163, 81, 222, 143, 156, 11, 220, 70, 128, 20, 6, 224, 188, 199, 213, 37 },
                            AccountRole = "user"
                        },
                        new
                        {
                            AccountId = new Guid("5c9b720b-544e-4056-85e5-461cf03761d6"),
                            AccountName = "user4",
                            AccountPasswordHash = new byte[] { 17, 68, 97, 109, 240, 103, 120, 40, 162, 103, 172, 81, 16, 155, 200, 27, 17, 251, 218, 47, 237, 6, 183, 244, 27, 68, 79, 78, 54, 62, 8, 112 },
                            AccountPasswordSalt = new byte[] { 146, 211, 18, 117, 74, 30, 233, 250, 210, 22, 28, 198, 17, 3, 39, 179, 131, 89, 153, 230, 1, 136, 64, 104, 52, 88, 88, 241, 247, 207, 23, 60, 167, 245, 240, 144, 9, 253, 213, 237, 242, 53, 98, 77, 77, 191, 85, 229, 13, 204, 113, 23, 36, 89, 210, 180, 163, 231, 106, 35, 49, 146, 126, 43 },
                            AccountRole = "user"
                        },
                        new
                        {
                            AccountId = new Guid("85c9329c-fabe-4aaa-b882-cbaee9bddc5d"),
                            AccountName = "user5",
                            AccountPasswordHash = new byte[] { 175, 124, 34, 183, 156, 95, 206, 149, 26, 91, 62, 94, 138, 251, 57, 126, 252, 190, 49, 51, 51, 4, 64, 181, 86, 174, 184, 117, 93, 42, 68, 121 },
                            AccountPasswordSalt = new byte[] { 204, 234, 226, 87, 101, 23, 24, 71, 3, 14, 212, 229, 79, 135, 112, 109, 29, 186, 188, 164, 92, 145, 149, 52, 76, 158, 198, 181, 119, 131, 156, 102, 170, 56, 35, 181, 137, 198, 116, 191, 11, 148, 207, 170, 227, 65, 188, 18, 244, 146, 151, 170, 177, 126, 5, 232, 27, 115, 229, 143, 60, 192, 7, 188 },
                            AccountRole = "user"
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserIdentityNumber")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserResidenceApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserResidenceCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserResidenceHouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserResidenceStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("875ee5a6-bfb9-4662-a74f-3ed10c2e940c"),
                            AccountId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserCountry = "USA",
                            UserEmail = "john.doe@example.com",
                            UserIdentityNumber = 12345,
                            UserName = "John",
                            UserResidenceCity = "New York",
                            UserResidenceHouseNumber = "123",
                            UserResidenceStreet = "Broadway",
                            UserSurName = "Doe"
                        },
                        new
                        {
                            Id = new Guid("95c5de67-ef48-46b4-a94d-8a9ad45db882"),
                            AccountId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserCountry = "Canada",
                            UserEmail = "jane.smith@example.com",
                            UserIdentityNumber = 54321,
                            UserName = "Jane",
                            UserResidenceCity = "Toronto",
                            UserResidenceHouseNumber = "456",
                            UserResidenceStreet = "Queen Street",
                            UserSurName = "Smith"
                        },
                        new
                        {
                            Id = new Guid("b5fcd216-0b0e-46ae-b780-144d62dd1478"),
                            AccountId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserCountry = "Australia",
                            UserEmail = "alice.johnson@example.com",
                            UserIdentityNumber = 98765,
                            UserName = "Alice",
                            UserResidenceCity = "Sydney",
                            UserResidenceHouseNumber = "789",
                            UserResidenceStreet = "George Street",
                            UserSurName = "Johnson"
                        },
                        new
                        {
                            Id = new Guid("61330907-5574-47fa-bbd0-9f7c03c2104c"),
                            AccountId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserCountry = "UK",
                            UserEmail = "bob.brown@example.com",
                            UserIdentityNumber = 67890,
                            UserName = "Bob",
                            UserResidenceCity = "London",
                            UserResidenceHouseNumber = "221B",
                            UserResidenceStreet = "Baker Street",
                            UserSurName = "Brown"
                        },
                        new
                        {
                            Id = new Guid("7001915e-ee75-4403-b4d3-9bff679a9f05"),
                            AccountId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserCountry = "New Zealand",
                            UserEmail = "emily.davis@example.com",
                            UserIdentityNumber = 12321,
                            UserName = "Emily",
                            UserResidenceCity = "Auckland",
                            UserResidenceHouseNumber = "102",
                            UserResidenceStreet = "Victoria Street",
                            UserSurName = "Davis"
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("Account", "Account")
                        .WithOne("User")
                        .HasForeignKey("User", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Account", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
