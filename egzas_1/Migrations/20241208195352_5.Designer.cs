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
    [Migration("20241208195352_5")]
    partial class _5
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
                            AccountId = new Guid("00000000-0000-0000-0000-000000000001"),
                            AccountName = "user1",
                            AccountPasswordHash = new byte[] { 212, 144, 177, 106, 252, 72, 226, 231, 82, 208, 67, 144, 6, 71, 154, 239, 41, 29, 129, 194, 228, 133, 46, 209, 106, 68, 64, 49, 34, 68, 48, 36 },
                            AccountPasswordSalt = new byte[] { 233, 82, 22, 65, 130, 60, 205, 194, 171, 168, 73, 66, 74, 226, 130, 216, 169, 243, 137, 170, 21, 96, 235, 143, 201, 248, 150, 228, 156, 217, 176, 233, 221, 217, 105, 253, 130, 132, 153, 227, 28, 133, 106, 196, 117, 86, 177, 29, 149, 61, 11, 85, 29, 118, 254, 128, 53, 91, 5, 52, 74, 144, 113, 190 },
                            AccountRole = "admin"
                        },
                        new
                        {
                            AccountId = new Guid("00000000-0000-0000-0000-000000000002"),
                            AccountName = "user2",
                            AccountPasswordHash = new byte[] { 174, 176, 238, 81, 181, 103, 172, 214, 50, 94, 222, 22, 124, 100, 161, 9, 147, 99, 182, 85, 13, 103, 111, 102, 160, 193, 149, 67, 48, 159, 241, 112 },
                            AccountPasswordSalt = new byte[] { 249, 204, 89, 254, 194, 121, 190, 149, 96, 192, 102, 204, 217, 25, 135, 199, 25, 117, 22, 200, 181, 19, 208, 176, 228, 250, 123, 118, 228, 133, 121, 186, 64, 64, 37, 158, 140, 180, 200, 115, 174, 144, 192, 247, 6, 87, 193, 81, 31, 113, 44, 188, 86, 183, 72, 77, 26, 82, 129, 238, 60, 185, 241, 45 },
                            AccountRole = "admin"
                        },
                        new
                        {
                            AccountId = new Guid("00000000-0000-0000-0000-000000000003"),
                            AccountName = "user3",
                            AccountPasswordHash = new byte[] { 199, 242, 53, 74, 172, 145, 78, 106, 193, 10, 235, 98, 49, 114, 189, 247, 144, 195, 64, 49, 117, 28, 78, 128, 15, 60, 182, 154, 15, 182, 139, 178 },
                            AccountPasswordSalt = new byte[] { 142, 29, 89, 156, 105, 214, 7, 34, 80, 198, 198, 10, 103, 98, 123, 224, 122, 92, 138, 217, 211, 8, 21, 45, 199, 32, 42, 130, 17, 56, 180, 132, 85, 145, 237, 40, 111, 210, 133, 188, 248, 157, 103, 21, 133, 10, 75, 18, 231, 81, 68, 50, 212, 107, 29, 80, 72, 53, 123, 241, 134, 25, 86, 188 },
                            AccountRole = "admin"
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
                            Id = new Guid("62c8be40-3ef7-45f0-a72a-e917331dc525"),
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
                            Id = new Guid("eed34b20-05c5-401c-8c04-823ebfb92ca4"),
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
                            Id = new Guid("563f9e56-b8fa-47a6-bfb1-48bdbef14437"),
                            AccountId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserCountry = "Australia",
                            UserEmail = "alice.johnson@example.com",
                            UserIdentityNumber = 98765,
                            UserName = "Alice",
                            UserResidenceCity = "Sydney",
                            UserResidenceHouseNumber = "789",
                            UserResidenceStreet = "George Street",
                            UserSurName = "Johnson"
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
