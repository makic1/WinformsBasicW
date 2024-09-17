using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StageManagmentTwo.Migrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArtistCategorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "ProgramStages",
                columns: table => new
                {
                    ProgramStageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PriceEuro = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    StartPaidEuro = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    EndPaidEuro = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramStages", x => x.ProgramStageId);
                    table.ForeignKey(
                        name: "FK_ProgramStages_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    PerfomanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SartPerformance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndPerformance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProgramStageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.PerfomanceId);
                    table.ForeignKey(
                        name: "FK_Performances_ProgramStages_ProgramStageId",
                        column: x => x.ProgramStageId,
                        principalTable: "ProgramStages",
                        principalColumn: "ProgramStageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatRow = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerFirstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerLastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerCategorie = table.Column<int>(type: "int", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CustomerCountry = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CustomerPLZ = table.Column<int>(type: "int", nullable: false),
                    PriceEuro = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: false),
                    PayedPriceEuro = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: true),
                    ProgramStageId = table.Column<int>(type: "int", nullable: false),
                    PerformancePerfomanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Performances_PerformancePerfomanceId",
                        column: x => x.PerformancePerfomanceId,
                        principalTable: "Performances",
                        principalColumn: "PerfomanceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Username",
                table: "Accounts",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performances_ProgramStageId",
                table: "Performances",
                column: "ProgramStageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramStages_ArtistId",
                table: "ProgramStages",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PerformancePerfomanceId",
                table: "Tickets",
                column: "PerformancePerfomanceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "ProgramStages");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
