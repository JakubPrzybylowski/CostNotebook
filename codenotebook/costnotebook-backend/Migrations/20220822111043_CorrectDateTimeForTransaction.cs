using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace costnotebook_backend.Migrations
{
    public partial class CorrectDateTimeForTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 5, 12, 12, 52, 12, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 5, 12, 16, 11, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 5, 12, 16, 11, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 5, 12, 20, 32, 48, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 5, 12, 22, 13, 27, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 5, 13, 17, 32, 43, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 5, 13, 20, 42, 12, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 5, 14, 14, 40, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 5, 14, 20, 40, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 5, 15, 20, 43, 12, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 5, 15, 21, 52, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 5, 16, 8, 42, 32, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 5, 16, 14, 53, 23, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 5, 16, 19, 27, 49, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 5, 16, 21, 32, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 5, 17, 19, 42, 57, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 5, 17, 23, 27, 23, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 5, 18, 7, 39, 20, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 5, 18, 17, 32, 24, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 5, 18, 20, 45, 21, 0, DateTimeKind.Unspecified));
        }
    }
}
