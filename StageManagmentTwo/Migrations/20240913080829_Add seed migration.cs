using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StageManagmentTwo.Migrations
{
    /// <inheritdoc />
    public partial class Addseedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "HashPassword", "Username" },
                values: new object[] { 1, "$2a$11$hQZIGUd63kjAtcJD4qqfzuCt3H7/WcRJwcHh4itkfKfTmdJKaXVfO", "admin" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistCategorie", "ArtistName" },
                values: new object[] { 1, 1, "Bushido" });

            migrationBuilder.InsertData(
                table: "ProgramStages",
                columns: new[] { "ProgramStageId", "ArtistId", "Duration", "EndPaidEuro", "IsPaid", "Name", "PriceEuro", "StartPaidEuro" },
                values: new object[] { 1, 1, new TimeSpan(0, 12, 50, 23, 0), 4900m, true, "Junge Berliner", 5000m, 100m });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "PerfomanceId", "EndPerformance", "IsActive", "Name", "ProgramStageId", "SartPerformance" },
                values: new object[] { 1, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Berliner 1", 1, new DateTime(2024, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "CustomerAddress", "CustomerCategorie", "CustomerCountry", "CustomerFirstname", "CustomerLastname", "CustomerPLZ", "PayedPriceEuro", "PerformanceId", "PriceEuro", "SeatNumber", "SeatRow" },
                values: new object[] { 1, "Hauptstrasse 83a", 0, "Feldkirch", "Ana", "Stanisic", 4854, 100, 1, 100, 1, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "PerfomanceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgramStages",
                keyColumn: "ProgramStageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);
        }
    }
}
