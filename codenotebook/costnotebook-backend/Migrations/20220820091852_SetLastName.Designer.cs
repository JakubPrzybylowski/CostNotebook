﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using costnotebook_backend.Models;

#nullable disable

namespace costnotebook_backend.Migrations
{
    [DbContext(typeof(CostNotebookDbContext))]
    [Migration("20220820091852_SetLastName")]
    partial class SetLastName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("costnotebook_backend.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            TransactionId = 1,
                            Amount = -50.68,
                            Category = 12,
                            Date = new DateTime(2021, 5, 12, 12, 52, 12, 0, DateTimeKind.Unspecified),
                            Description = "IKEA",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 2,
                            Amount = -75.890000000000001,
                            Category = 0,
                            Date = new DateTime(2021, 5, 12, 16, 11, 20, 0, DateTimeKind.Unspecified),
                            Description = "JMP S.A BIEDRONKA 1862",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 3,
                            Amount = -75.890000000000001,
                            Category = 0,
                            Date = new DateTime(2021, 5, 12, 16, 11, 20, 0, DateTimeKind.Unspecified),
                            Description = "JMP S.A BIEDRONKA 1862",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 4,
                            Amount = -21.289999999999999,
                            Category = 0,
                            Date = new DateTime(2021, 5, 12, 20, 32, 48, 0, DateTimeKind.Unspecified),
                            Description = "ZABKA Z8235 K.1",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 5,
                            Amount = -10.779999999999999,
                            Category = 1,
                            Date = new DateTime(2021, 5, 12, 22, 13, 27, 0, DateTimeKind.Unspecified),
                            Description = "BOLT.EU/R/236296201",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 6,
                            Amount = -180.90000000000001,
                            Category = 12,
                            Date = new DateTime(2021, 5, 13, 17, 32, 43, 0, DateTimeKind.Unspecified),
                            Description = "IKEA Retail Sp. z o",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 7,
                            Amount = -75.640000000000001,
                            Category = 4,
                            Date = new DateTime(2021, 5, 13, 20, 42, 12, 0, DateTimeKind.Unspecified),
                            Description = "KAPSEL",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 8,
                            Amount = -209.90000000000001,
                            Category = 3,
                            Date = new DateTime(2021, 5, 14, 14, 40, 20, 0, DateTimeKind.Unspecified),
                            Description = "KOMFORT",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 9,
                            Amount = -100.0,
                            Category = 5,
                            Date = new DateTime(2021, 5, 14, 20, 40, 20, 0, DateTimeKind.Unspecified),
                            Description = "JAN KOWALSKI-MONEY TRANSFER",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 10,
                            Amount = -18.0,
                            Category = 6,
                            Date = new DateTime(2021, 5, 15, 20, 43, 12, 0, DateTimeKind.Unspecified),
                            Description = "SERWUS BABKI SP. 12301",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 11,
                            Amount = -24.899999999999999,
                            Category = 7,
                            Date = new DateTime(2021, 5, 15, 21, 52, 20, 0, DateTimeKind.Unspecified),
                            Description = "ENERGA-MONEY TRANSFER",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 12,
                            Amount = -209.90000000000001,
                            Category = 0,
                            Date = new DateTime(2021, 5, 16, 8, 42, 32, 0, DateTimeKind.Unspecified),
                            Description = "JMP S.A BIEDRONKA 1862",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 13,
                            Amount = 5670.0,
                            Category = 9,
                            Date = new DateTime(2021, 5, 16, 14, 53, 23, 0, DateTimeKind.Unspecified),
                            Description = "DEV-COMPANY",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 14,
                            Amount = -58.0,
                            Category = 8,
                            Date = new DateTime(2021, 5, 16, 19, 27, 49, 0, DateTimeKind.Unspecified),
                            Description = "BIURO PRZEWODNICKIE PIERN",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 15,
                            Amount = -7.9800000000000004,
                            Category = 0,
                            Date = new DateTime(2021, 5, 16, 21, 32, 20, 0, DateTimeKind.Unspecified),
                            Description = "ZABKA Z8235 K.1",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 16,
                            Amount = -7.9800000000000004,
                            Category = 6,
                            Date = new DateTime(2021, 5, 17, 19, 42, 57, 0, DateTimeKind.Unspecified),
                            Description = "ZAHIRE KEBAB TORUN O",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 17,
                            Amount = -7.9800000000000004,
                            Category = 6,
                            Date = new DateTime(2021, 5, 17, 23, 27, 23, 0, DateTimeKind.Unspecified),
                            Description = "BOLT.EU/R/2134363",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 18,
                            Amount = -48.899999999999999,
                            Category = 0,
                            Date = new DateTime(2021, 5, 18, 7, 39, 20, 0, DateTimeKind.Unspecified),
                            Description = "JMP S.A BIEDRONKA 1862",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 19,
                            Amount = 20.0,
                            Category = 2,
                            Date = new DateTime(2021, 5, 18, 17, 32, 24, 0, DateTimeKind.Unspecified),
                            Description = "BLIK P2P-INCOMING",
                            UserId = 4
                        },
                        new
                        {
                            TransactionId = 20,
                            Amount = -309.80000000000001,
                            Category = 11,
                            Date = new DateTime(2021, 5, 18, 20, 45, 21, 0, DateTimeKind.Unspecified),
                            Description = "ORLEN",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("costnotebook_backend.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            FirstName = "Jakub",
                            LastName = "Przy",
                            Password = "pass123",
                            UserEmail = "jakukprzybyl@gmail.com"
                        },
                        new
                        {
                            UserID = 2,
                            FirstName = "Krzysztof",
                            LastName = "Dob",
                            Password = "pass123",
                            UserEmail = "krzychudobrz@gmail.com"
                        },
                        new
                        {
                            UserID = 3,
                            FirstName = "Łukasz",
                            LastName = "Przy",
                            Password = "pass123",
                            UserEmail = "lukaszprzybyl@gmail.com"
                        },
                        new
                        {
                            UserID = 4,
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "admin",
                            UserEmail = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("costnotebook_backend.Models.Transaction", b =>
                {
                    b.HasOne("costnotebook_backend.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("costnotebook_backend.Models.User", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
