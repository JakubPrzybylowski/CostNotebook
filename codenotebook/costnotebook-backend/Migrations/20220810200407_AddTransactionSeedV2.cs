using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace costnotebook_backend.Migrations
{
    public partial class AddTransactionSeedV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "Category", "Data", "Description", "UserId" },
                values: new object[,]
                {
                    { 2, -75.890000000000001, 0, new DateTime(2021, 5, 12, 16, 11, 20, 0, DateTimeKind.Unspecified), "JMP S.A BIEDRONKA 1862", 4 },
                    { 3, -75.890000000000001, 0, new DateTime(2021, 5, 12, 16, 11, 20, 0, DateTimeKind.Unspecified), "JMP S.A BIEDRONKA 1862", 4 },
                    { 4, -21.289999999999999, 0, new DateTime(2021, 5, 12, 20, 32, 48, 0, DateTimeKind.Unspecified), "ZABKA Z8235 K.1", 4 },
                    { 5, -10.779999999999999, 1, new DateTime(2021, 5, 12, 22, 13, 27, 0, DateTimeKind.Unspecified), "BOLT.EU/R/236296201", 4 },
                    { 6, -180.90000000000001, 12, new DateTime(2021, 5, 13, 17, 32, 43, 0, DateTimeKind.Unspecified), "IKEA Retail Sp. z o", 4 },
                    { 7, -75.640000000000001, 4, new DateTime(2021, 5, 13, 20, 42, 12, 0, DateTimeKind.Unspecified), "KAPSEL", 4 },
                    { 8, -209.90000000000001, 3, new DateTime(2021, 5, 14, 14, 40, 20, 0, DateTimeKind.Unspecified), "KOMFORT", 4 },
                    { 9, -100.0, 5, new DateTime(2021, 5, 14, 20, 40, 20, 0, DateTimeKind.Unspecified), "JAN KOWALSKI-MONEY TRANSFER", 4 },
                    { 10, -18.0, 6, new DateTime(2021, 5, 15, 20, 43, 12, 0, DateTimeKind.Unspecified), "SERWUS BABKI SP. 12301", 4 },
                    { 11, -24.899999999999999, 7, new DateTime(2021, 5, 15, 21, 52, 20, 0, DateTimeKind.Unspecified), "ENERGA-MONEY TRANSFER", 4 },
                    { 12, -209.90000000000001, 0, new DateTime(2021, 5, 16, 8, 42, 32, 0, DateTimeKind.Unspecified), "JMP S.A BIEDRONKA 1862", 4 },
                    { 13, 5670.0, 9, new DateTime(2021, 5, 16, 14, 53, 23, 0, DateTimeKind.Unspecified), "DEV-COMPANY", 4 },
                    { 14, -58.0, 8, new DateTime(2021, 5, 16, 19, 27, 49, 0, DateTimeKind.Unspecified), "BIURO PRZEWODNICKIE PIERN", 4 },
                    { 15, -7.9800000000000004, 0, new DateTime(2021, 5, 16, 21, 32, 20, 0, DateTimeKind.Unspecified), "ZABKA Z8235 K.1", 4 },
                    { 16, -7.9800000000000004, 6, new DateTime(2021, 5, 17, 19, 42, 57, 0, DateTimeKind.Unspecified), "ZAHIRE KEBAB TORUN O", 4 },
                    { 17, -7.9800000000000004, 6, new DateTime(2021, 5, 17, 23, 27, 23, 0, DateTimeKind.Unspecified), "BOLT.EU/R/2134363", 4 },
                    { 18, -48.899999999999999, 0, new DateTime(2021, 5, 18, 7, 39, 20, 0, DateTimeKind.Unspecified), "JMP S.A BIEDRONKA 1862", 4 },
                    { 19, 20.0, 2, new DateTime(2021, 5, 18, 17, 32, 24, 0, DateTimeKind.Unspecified), "BLIK P2P-INCOMING", 4 },
                    { 20, -309.80000000000001, 11, new DateTime(2021, 5, 18, 20, 45, 21, 0, DateTimeKind.Unspecified), "ORLEN", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20);
        }
    }
}
